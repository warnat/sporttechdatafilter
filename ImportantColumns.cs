using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trampolin.FilterSportTecResults
{
    public class ImportantColumns
    {
    // #, UUID,Title,Subtitle,Discipline,Competition,Stage,Group #,Time,Performance #,Ranked,Rank,Mark Total,Team,Team Rank,Team Mark,Code,Athlete #,External ID,Surname,Given Name,Representing,Date of Birth,Sex,Routine #,Mark,# Elements,Bonus,Penalty,Judge,∑,S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,L,A

        public string Competition { get; set; }
        public string Discipline { get; set; }
        public string Stage { get; set; }
        public string Ranked { get; set; }
        public string Rank { get; set; }
        public string MarkTotal { get; set; }

        // Surname,Given Name,Representing
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string Representing { get; set; }
        public string Judge { get; set; }
        public string Sum { get; set; }
        public string Routine { get; set; }

    }

    public class Eintrag
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Verein { get; set; }
        public string Art { get; set; }
        public string Klasse { get; set; }
        public int Platz { get; set; }
        public double Punkte { get; set; }
        public int Durchgang { get; set; }
        public string Phase { get; set; }
    }
}
