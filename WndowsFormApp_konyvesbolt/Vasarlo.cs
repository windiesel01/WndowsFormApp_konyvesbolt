using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndowsFormApp_konyvesbolt
{
    public class Vasarlo
    {
        int vasarloID;
        string nev;
        DateTime datum;
        string email;
        string felhasznalonev;


        public int VasarloID { get => vasarloID; set => vasarloID = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Email { get => email; set => email = value; }
        public string Felhasznalonev { get => felhasznalonev; set => felhasznalonev = value; }


        public Vasarlo(int vasarloID, string nev, DateTime datum, string email, string felhasznalonev)
        {
            this.vasarloID = vasarloID;
            this.nev = nev;
            this.datum = datum;
            this.email = email;
            this.felhasznalonev = felhasznalonev;

        }

        public override string ToString()
        {
            return $"{Nev} - ({Felhasznalonev})";
        }
    }

}
