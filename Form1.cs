using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataAccess;

namespace Trampolin.FilterSportTecResults
{
    public partial class Form1 : Form
    {
        private List<Eintrag> zeilen = new List<Eintrag>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, System.EventArgs e)
        {
            string fname = txtInputFileName.Text.Replace("\"", "");

            var dt = DataTable.New.ReadLazy(fname);

            zeilen = new List<Eintrag>();
            int count = 0;
            foreach (var row in dt.Rows)
            {
                if (row["Judge"] != "E∑") continue;
                if (row["Discipline"] != "TRA") continue;
                if (row["Competition"].Contains("TEAM")) continue;

                var eintrag = new Eintrag
                {
                    Vorname = row["Given Name"],
                    Nachname = row["Surname"],
                    Verein = row["Representing"],
                    Klasse = row["Competition"],
                    Art = row["Discipline"],
                    Platz = int.Parse(row["Rank"]),
                    Punkte = double.Parse(row["Mark Total"]) / 1000,
                    Durchgang = int.Parse(row["Routine #"])
                };

                var suche = zeilen.FirstOrDefault(
                    x => x.Vorname == eintrag.Vorname
                        && x.Nachname == eintrag.Nachname
                        && x.Klasse == eintrag.Klasse
                        && x.Art == eintrag.Art);
                if (suche != null)
                {
                    if (suche.Durchgang < eintrag.Durchgang)
                    {
                        suche.Durchgang = eintrag.Durchgang;
                        suche.Platz = eintrag.Platz;
                        suche.Punkte = eintrag.Punkte;
                    }
                    continue;
                }

                zeilen.Add(eintrag);
                count++;
                //if (count > 100) break;
            }

            cmbClassFilter.Items.AddRange(zeilen.Select(ee => ee.Klasse).Distinct().ToArray());
            cmbClassFilter.SelectedItem = cmbClassFilter.Items[0];

            zeilen = zeilen.OrderBy(ee => ee.Klasse).ThenBy(ee => ee.Platz).ToList();

            gridInput.DataSource = zeilen;
            tabs.SelectedIndex = 1;
        }

        private void txtInputFileName_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtInputFileName_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtInputFileName.Text = files[0];
            }
        }

        private int _previousIndex;
        private bool _sortDirection;
        private void gridInput_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == _previousIndex)
                _sortDirection ^= true; // toggle direction

            gridInput.DataSource = SortData(
                (List<Eintrag>)gridInput.DataSource, gridInput.Columns[e.ColumnIndex].Name, _sortDirection);

            _previousIndex = e.ColumnIndex;
        }

        public List<Eintrag> SortData(List<Eintrag> list, string column, bool ascending)
        {
            return ascending ?
                list.OrderBy(_ => _.GetType().GetProperty(column).GetValue(_)).ToList() :
                list.OrderByDescending(_ => _.GetType().GetProperty(column).GetValue(_)).ToList();
        }

        private static string dbl(double z)
        {
            return z.ToString("##0.000").Replace(".", ",");
        }

        private void btnCreateOutputLtePlace_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            tabs.SelectedIndex = 3;
            int place = int.Parse(txtPlaceFilter.Text);

            foreach (var item in zeilen)
            {
                if (item.Klasse != cmbClassFilter.SelectedItem.ToString()) continue;
                if (item.Platz <= place)
                {
                    txtOutput.Text += item.Klasse + "\t" + item.Platz + "\t" + dbl(item.Punkte) + "\t" + item.Vorname + "\t" + item.Nachname + "\t" + item.Verein + "\r\n";
                }
            }
        }

        private void btnCreateOutputGtPlace_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            tabs.SelectedIndex = 3;
            int place = int.Parse(txtPlaceFilter.Text);

            foreach (var item in zeilen)
            {
                if (item.Klasse != cmbClassFilter.SelectedItem.ToString()) continue;
                if (item.Platz > place)
                {
                    txtOutput.Text += item.Klasse + "\t" + item.Platz + "\t" + dbl(item.Punkte) + "\t" + item.Vorname + "\t" + item.Nachname + "\t" + item.Verein + "\r\n";
                }
            }
        }

        private void btnMakePdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutput.Text)) return;

            try
            {
                if (!string.IsNullOrEmpty(txtTemplate.Text))
                    File.WriteAllText("template.tex", txtTemplate.Text);
            }
            catch (Exception ex)
            {
            }


            string header = "";
            string template = "";
            string footer = "";
            bool inHeader = true;
            bool inTemplate = false;
            bool inFooter = false;
            foreach (var line in txtTemplate.Text.Split('\n'))
            {
                string l = line.Replace("\r", "").Trim();
                if (l.StartsWith("%%"))
                {
                    if (inHeader && l.Contains("FOREACH") && l.Contains("ITEM"))
                    {
                        inHeader = false; inTemplate = true; inFooter = false;
                        continue;
                    }
                    if (inTemplate && l.Contains("NEXT") && l.Contains("ITEM"))
                    {
                        inHeader = false; inTemplate = false; inFooter = true;
                        continue;
                    }
                }

                if (inTemplate && l.Contains("%%") && l.Contains("REPLACE"))
                {
                    l = l.Substring(l.IndexOf("REPLACE") + 7).Trim();
                    l = l.Replace("VORNAME", "!!VOR!!");
                    l = l.Replace("NAME", "%%NAME%%");
                    l = l.Replace("!!VOR!!", "%%VORNAME%%");
                    l = l.Replace("WETTKAMPFKLASSE", "%%WETTKAMPFKLASSE%%");
                    l = l.Replace("VEREIN", "%%VEREIN%%");
                    l = l.Replace("PLATZ", "%%PLATZ%%");
                    l = l.Replace("PUNKTE", "%%PUNKTE%%");
                    template += l + "\r\n";
                    continue;
                }


                if (inHeader) header += l + "\r\n";
                if (inTemplate) template += l + "\r\n";
                if (inFooter) footer += l + "\r\n";
            }

            string result = "";
            result += header + "\r\n";
            foreach (var line in txtOutput.Text.Split('\n'))
            {
                string l = line.Replace("\r", "").Trim();
                if (string.IsNullOrEmpty(l)) continue;

                string[] entries = l.Split('\t');
                string r = template;

                string klasse = entries[0];
                string platz = entries[1];
                string punkte = entries[2];
                string vorname = entries[3];
                string name = entries[4];
                string verein = entries[5];

                r = r.Replace("%%WETTKAMPFKLASSE%%", klasse);
                r = r.Replace("%%VORNAME%%", vorname);
                r = r.Replace("%%NAME%%", name);
                r = r.Replace("%%PLATZ%%", platz);
                r = r.Replace("%%PUNKTE%%", punkte);
                r = r.Replace("%%VEREIN%%", verein);

                result += r + "\r\n";
            }
            result += footer + "\r\n";

            try
            {
                System.IO.File.WriteAllText("output.tex", result);

                var pdf = System.Diagnostics.Process.Start("pdflatex", "output.tex");

                System.Threading.Thread.Sleep(1000);

                if (pdf.HasExited)
                    System.Diagnostics.Process.Start("output.pdf");
                else
                {
                    pdf.WaitForExit(2000);
                    System.Diagnostics.Process.Start("output.pdf");
                }
            }
            catch (Exception ex)
            {
            }
        }

        bool first_time = true;
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first_time)
            {
                if (tabs.SelectedIndex == 4)
                {
                    try
                    {
                        if (File.Exists("template.tex"))
                            txtTemplate.Text = File.ReadAllText("template.tex");
                        first_time = false;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
}
