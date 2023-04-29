using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WndowsFormApp_konyvesbolt
{

    public partial class NyitoForm : Form
    {
        Database database = new Database();

        public NyitoForm()
        {
            InitializeComponent();
        }


        private void NyitoForm_Load(object sender, EventArgs e)
        {
            VasarlokBetoltese();
            KonyvekBetoltese();
        }

        public void KonyvekBetoltese()
        {
            listBox_konyvek.Items.Clear();
            foreach (Konyv item in database.getAllKonyv())
            {
                listBox_konyvek.Items.Add(item);
            }
        }
        public void VasarlokBetoltese()
        {
            listBox_konyvek.Items.Clear();
            foreach (Vasarlo item in database.getAllVasarlo())
            {
                listBox_vasarlok.Items.Add(item);
            }
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.konyvekinsert.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.konyvekDelete.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.konyvekUpdate.ShowDialog();
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.vasarlokInsert.ShowDialog();
        }

        private void törlésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.vasarlokDelete.ShowDialog();
        }

        private void módosításToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.VasarlokUpdate.ShowDialog();
        }
    }
}
