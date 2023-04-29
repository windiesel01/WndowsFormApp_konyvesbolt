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
    public partial class KonyvekUpdate : Form
    {
        Database database = new Database();
        public KonyvekUpdate()
        {
            InitializeComponent();
        }

        private void KonyvekUpdate_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.nyitoform.listBox_konyvek.Text + " adatainak a módositása");
            Konyv ja = (Konyv)Program.nyitoform.listBox_konyvek.SelectedItem;
            textBox_konyvid.Text = Convert.ToString(ja.KonyvID);
            textBox_szerzo.Text = Convert.ToString(ja.Szerzo);
            textBox_cim.Text = Convert.ToString(ja.Cim);
            textBox_megjelenesev.Text = Convert.ToString(Convert.ToInt32(ja.Megjelent));
            textBox_megjeleneshelye.Text = Convert.ToString(ja.MegjelenesHelye);
            textBox_kiado.Text = Convert.ToString(ja.Kiado);
            textBox_kategoria.Text = Convert.ToString(ja.Kategoria);
            textBox_nyelv.Text = Convert.ToString(ja.Nyelv);
            textBox_sorozatcim.Text = Convert.ToString(ja.Sorozatcim);
            textBox_isbn.Text = Convert.ToString(ja.Isbn);
            textBox_ar.Text = Convert.ToString(Convert.ToInt32(ja.Ar));
        }

        private void button_modisitas_Click(object sender, EventArgs e)
        {
            Konyv KonyvekUpdate = new Konyv(1,textBox_szerzo.Text, textBox_cim.Text, Convert.ToInt32(textBox_megjelenesev.Text), textBox_megjeleneshelye.Text, textBox_kiado.Text, textBox_kategoria.Text, textBox_nyelv.Text, textBox_sorozatcim.Text, textBox_isbn.Text, Convert.ToInt32(textBox_ar.Text));
            if (database.KonyvekUpdate(KonyvekUpdate))
            {
                MessageBox.Show("Sikeres módosítás!");
                textBox_konyvid.Text = "";
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
                MessageBox.Show("Sikertelen módosítás!");
            }
            Program.nyitoform.KonyvekBetoltese();
            Close();
        }
    }
}
