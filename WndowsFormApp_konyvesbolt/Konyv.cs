using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndowsFormApp_konyvesbolt
{
    public class Konyv
    {
        int konyvID;
        string szerzo;
        string cim;
        int megjelent;
        string megjelenesHelye;
        string kiado;
        string kategoria;
        string nyelv;
        string sorozatcim;
        string isbn;
        int ar;

        public int KonyvID { get => konyvID; set => konyvID = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Megjelent { get => megjelent; set => megjelent = value; }
        public string MegjelenesHelye { get => megjelenesHelye; set => megjelenesHelye = value; }
        public string Kiado { get => kiado; set => kiado = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string Nyelv { get => nyelv; set => nyelv = value; }
        public string Sorozatcim { get => sorozatcim; set => sorozatcim = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Ar { get => ar; set => ar = value; }

        public Konyv(int konyvID, string szerzo, string cim, int megjelent, string megjelenesHelye, string kiado, string kategoria, string nyelv, string sorozatcim, string isbn, int ar)
        {
            this.KonyvID = konyvID;
            this.Szerzo = szerzo;
            this.Cim = cim;
            this.Megjelent = megjelent;
            this.MegjelenesHelye = megjelenesHelye;
            this.Kiado = kiado;
            this.Kategoria = kategoria;
            this.Nyelv = nyelv;
            this.Sorozatcim = sorozatcim;
            this.Isbn = isbn;
            this.Ar = ar;
        }

        public override string ToString()
        {
            return $"{Szerzo} - {Cim}({Megjelent})";
        }
    }
}
