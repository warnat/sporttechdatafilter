using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccess;

namespace Trampolin.FilterSportTecResults
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, System.EventArgs e)
        {
            string fname = txtInputFileName.Text.Replace("\"", "");

            // See methods on DataTable.New for loading a DataTable.
            var dt = DataTable.New.ReadLazy(fname); // Fast streaming load a CSV from disk. 

            var zeilen = new List<Eintrag>();
            int count = 0;
            foreach (var row in dt.Rows)
            {
                var item = row.As<ImportantColumns>();
                if (item.Judge != "E∑") continue;
                if (item.Discipline != "TRA") continue;
                if (item.Competition.Contains("TEAM")) continue;

                item.Sum = row.GetValueOrEmpty("∑");
                //System.Diagnostics.Debug.WriteLine(item.Competition + " " + item.Surname + " " + item.GivenName + " = " + item.MarkTotal + "/" + item.Routine);

                var eintrag = new Eintrag
                {
                    Vorname = item.GivenName,
                    Nachname = item.Surname,
                    Verein = item.Representing,
                    Klasse = item.Competition,
                    Art = item.Discipline,
                    Platz = int.Parse(item.Rank),
                    Punkte = double.Parse(item.MarkTotal) / 1000,
                    Durchgang = int.Parse(item.Routine)
                };

                if (true)
                {
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
                }

                zeilen.Add(eintrag);
                count++;
                //if (count > 100) break;
            }

            gridInput.DataSource = zeilen.OrderBy(ee=>ee.Klasse).ThenBy(ee=>ee.Platz).ToList();
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
    }
}
