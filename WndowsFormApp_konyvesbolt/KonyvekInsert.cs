using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndowsFormApp_konyvesbolt
{
    public partial class KonyvekInsert : Form
    {
        Database database = new Database();
        public KonyvekInsert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KonyvekInsert_Load(object sender, EventArgs e)
        {

        }

        private void button_feltolt_Click(object sender, EventArgs e)
        {
            Konyv KonyvekInsert = new Konyv(1, textBox_szerzo.Text, textBox_cim.Text, Convert.ToInt32(textBox_megjelenesev.Text), textBox_megjeleneshelye.Text, textBox_kiado.Text, textBox_kategoria.Text, textBox_nyelv.Text, textBox_sorozatcim.Text, textBox_isbn.Text, Convert.ToInt32(textBox_ar.Text));
            if (database.KonyvekInsert(KonyvekInsert))
            {
                MessageBox.Show("Sikeres rögzites!");
                textBox_szerzo.Text = "";
                textBox_cim.Text = "";
                textBox_megjelenesev.Text = "";
                textBox_megjeleneshelye.Text = "";
                textBox_kiado.Text = "";
                textBox_kategoria.Text = "";
                textBox_nyelv.Text = "";
                textBox_sorozatcim.Text = "";
                textBox_isbn.Text = "";
                textBox_ar.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzites!");
            }
            Program.nyitoform.KonyvekBetoltese();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
