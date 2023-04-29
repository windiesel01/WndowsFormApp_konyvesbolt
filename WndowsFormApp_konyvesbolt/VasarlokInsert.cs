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
    public partial class VasarlokInsert : Form
    {
        Database database = new Database();
        public VasarlokInsert()
        {
            InitializeComponent();
        }

        private void VasarlokInsert_Load(object sender, EventArgs e)
        {

        }


        private void button_feltoltes_Click(object sender, EventArgs e)
        {
            Vasarlo vasarloInsert = new Vasarlo(1, textBox_nev.Text, Convert.ToDateTime(dateTimePicker_szuletesidatum.Text), textBox_emailcim.Text, textBox_felhasznalonev.Text);
            if (database.VasarlokInsert(vasarloInsert))
            {
                MessageBox.Show("Sikeres rögzites!");
                textBox_nev.Text = "";
                dateTimePicker_szuletesidatum.Text = "";
                textBox_emailcim.Text = "";
                textBox_felhasznalonev.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzites!");
            }
            Program.nyitoform.VasarlokBetoltese();
        }
    }
}
