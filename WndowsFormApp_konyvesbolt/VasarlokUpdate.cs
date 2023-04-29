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
    public partial class VasarlokUpdate : Form
    {
        Database database = new Database();
        public VasarlokUpdate()
        {
            InitializeComponent();
        }

        private void VasarlokUpdate_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.nyitoform.listBox_vasarlok.Text + " adatainak törlése");
            Vasarlo ja = (Vasarlo)Program.nyitoform.listBox_vasarlok.SelectedItem;
            textBox_vasarloid.Text = Convert.ToString(ja.VasarloID);
            textBox_nev.Text = Convert.ToString(ja.Nev);
            dateTimePicker_szuletesidatum.Text = Convert.ToString(ja.Datum);
            textBox_emailcim.Text = Convert.ToString(ja.Email);
            textBox_felhasznalonev.Text = Convert.ToString(ja.Felhasznalonev);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Vasarlo VasarlokUpdate = new Vasarlo(1, textBox_nev.Text, Convert.ToDateTime(dateTimePicker_szuletesidatum.Text), textBox_emailcim.Text, textBox_felhasznalonev.Text);
            if (database.VasarlokUpdate(VasarlokUpdate))
            {
                MessageBox.Show("Sikeres módosítás!");
                textBox_nev.Text = "";
                dateTimePicker_szuletesidatum.Text = "";
                textBox_emailcim.Text = "";
                textBox_felhasznalonev.Text = "";
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
