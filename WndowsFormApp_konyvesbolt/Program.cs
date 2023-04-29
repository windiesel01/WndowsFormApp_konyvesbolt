using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndowsFormApp_konyvesbolt
{
    public static class Program
    {
        static public KonyvekInsert konyvekinsert = new KonyvekInsert();
        static public KonyvekUpdate konyvekUpdate = new KonyvekUpdate();
        static public KonyvekDelete konyvekDelete = new KonyvekDelete();
        static public VasarlokDelete vasarlokDelete = new VasarlokDelete();
        static public VasarlokUpdate VasarlokUpdate = new VasarlokUpdate();
        static public VasarlokInsert vasarlokInsert = new VasarlokInsert();
        static public NyitoForm nyitoform;
        public static Database database;
        [STAThread]
        static void Main()
        {
            database = new Database();
            Application.EnableVisualStyles();
            Application.Run(nyitoform = new NyitoForm());
        }
    }
}
