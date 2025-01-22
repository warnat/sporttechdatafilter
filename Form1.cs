using System;
using System.Collections.Generic;
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
    }
}
