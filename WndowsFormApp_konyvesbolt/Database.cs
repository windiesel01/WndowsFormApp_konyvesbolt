using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndowsFormApp_konyvesbolt
{
    public class Database
    {

        public MySqlConnection conn;
        public MySqlCommand cmd;

        public Database()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "konyvesbolt";
            conn = new MySqlConnection(sb.ConnectionString);
            if (Kapcsolatok())
            {
                cmd = conn.CreateCommand();
            }
        }


        private bool Kapcsolatok()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<Konyv> getAllKonyv()
        {
            List<Konyv> konyvek = new List<Konyv>();
            cmd.CommandText = "SELECT * FROM konyv;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Konyv ujKonyv = new Konyv(dr.GetInt32("konyvid"), dr.GetString("szerzo"), dr.GetString("cim"), dr.GetInt32("megjelenesi_ev"), dr.GetString("megjelenes_helye"), dr.GetString("kiado"),
                          dr.IsDBNull(6) ? "" : dr.GetString("kategoria"), dr.GetString("nyelv"),
                          dr.IsDBNull(8) ? "" : dr.GetString("sorozatcim"), dr.GetString("isbn"), dr.GetInt32("ar"));
                    konyvek.Add(ujKonyv);
                }
            }
            conn.Close();
            return konyvek;
        }

        public List<Vasarlo> getAllVasarlo()
        {
            List<Vasarlo> vasarlok = new List<Vasarlo>();
            cmd.CommandText = "SELECT * FROM vasarlo;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Vasarlo ujVasarlo = new Vasarlo(dr.GetInt32("vasarloid"), dr.GetString("nev"), dr.GetDateTime("szuletesi_datum"), dr.GetString("email_cim"), dr.GetString("felhasznalonev"));
                    vasarlok.Add(ujVasarlo);
                }
            }
            conn.Close();
            return vasarlok;
        }
        public bool KonyvekInsert(Konyv konyvekInsert) {

            cmd.CommandText = "INSERT INTO konyv (konyvid,szerzo,cim,megjelenesi_ev,megjelenes_helye,kiado,kategoria,nyelv,sorozatcim,isbn,ar) VALUES (null,@szerzo,@cim,@megjelenes_ev,@megjelenes_helye,@kiado,@kategoria,@nyelv,@sorozatcim,@isbn,@ar);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@szerzo", Program.konyvekinsert.textBox_szerzo.Text);
            cmd.Parameters.AddWithValue("@cim", Program.konyvekinsert.textBox_cim.Text);
            cmd.Parameters.AddWithValue("@megjelenes_ev", Program.konyvekinsert.textBox_megjelenesev.Text);
            cmd.Parameters.AddWithValue("@megjelenes_helye", Program.konyvekinsert.textBox_megjeleneshelye.Text);
            cmd.Parameters.AddWithValue("@kiado", Program.konyvekinsert.textBox_kiado.Text);
            cmd.Parameters.AddWithValue("@kategoria", Program.konyvekinsert.textBox_kategoria.Text);
            cmd.Parameters.AddWithValue("@nyelv", Program.konyvekinsert.textBox_nyelv.Text);
            cmd.Parameters.AddWithValue("@sorozatcim", Program.konyvekinsert.textBox_sorozatcim.Text);
            cmd.Parameters.AddWithValue("@isbn", Program.konyvekinsert.textBox_isbn.Text);
            cmd.Parameters.AddWithValue("@ar", Program.konyvekinsert.textBox_ar.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }
        public bool KonyvekUpdate(Konyv konyvekUpdate) {

            cmd.CommandText = "UPDATE `konyv` SET `szerzo`=@szerzo,`cim`=@cim,`megjelenesi_ev`=@megjelenes_ev,`megjelenes_helye`=@megjelenes_helye,`kiado`=@kiado,`kategoria`=@kategoria,`nyelv`=@nyelv,`sorozatcim`=@sorozatcim,`isbn`=@isbn,`ar`=@ar WHERE `konyvid`=@konyvid;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@konyvid", Program.konyvekUpdate.textBox_konyvid.Text);
            cmd.Parameters.AddWithValue("@szerzo", Program.konyvekUpdate.textBox_szerzo.Text);
            cmd.Parameters.AddWithValue("@cim", Program.konyvekUpdate.textBox_cim.Text);
            cmd.Parameters.AddWithValue("@megjelenes_ev", Program.konyvekUpdate.textBox_megjelenesev.Text);
            cmd.Parameters.AddWithValue("@megjelenes_helye", Program.konyvekUpdate.textBox_megjeleneshelye.Text);
            cmd.Parameters.AddWithValue("@kiado", Program.konyvekUpdate.textBox_kiado.Text);
            cmd.Parameters.AddWithValue("@kategoria", Program.konyvekUpdate.textBox_kategoria.Text);
            cmd.Parameters.AddWithValue("@nyelv", Program.konyvekUpdate.textBox_nyelv.Text);
            cmd.Parameters.AddWithValue("@sorozatcim", Program.konyvekUpdate.textBox_sorozatcim.Text);
            cmd.Parameters.AddWithValue("@isbn", Program.konyvekUpdate.textBox_isbn.Text);
            cmd.Parameters.AddWithValue("@ar", Program.konyvekUpdate.textBox_ar.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public bool KonyvekDelete(Konyv konyvekDelete) {

            cmd.CommandText = "DELETE FROM `konyv` WHERE `konyvid` = @konyvid;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@konyvid", Program.konyvekDelete.textBox_konyvid.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public bool VasarlokInsert(Vasarlo vasarlokInsert)
        {

            cmd.CommandText = "INSERT INTO `vasarlo`(`vasarloid`, `nev`, `szuletesi_datum`, `email_cim`, `felhasznalonev`) VALUES (null,@nev,@szuletesidatum,@emailcim,@felhasznalonev);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", Program.vasarlokInsert.textBox_nev.Text);
            cmd.Parameters.AddWithValue("@szuletesidatum", Program.vasarlokInsert.dateTimePicker_szuletesidatum.Text);
            cmd.Parameters.AddWithValue("@emailcim", Program.vasarlokInsert.textBox_emailcim.Text);
            cmd.Parameters.AddWithValue("@felhasznalonev", Program.vasarlokInsert.textBox_felhasznalonev.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public bool VasarlokUpdate(Vasarlo vasarlokUpdate)
        {

            cmd.CommandText = "UPDATE `vasarlo` SET nev=@nev, szuletesi_datum=@szuletesidatum,email_cim=@emailcim,felhasznalonev=@felhasznalonev WHERE vasarloid=@vasarloid;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@vasarloid", Program.VasarlokUpdate.textBox_vasarloid.Text);
            cmd.Parameters.AddWithValue("@nev", Program.VasarlokUpdate.textBox_nev.Text);
            cmd.Parameters.AddWithValue("@szuletesidatum", Program.VasarlokUpdate.dateTimePicker_szuletesidatum.Text);
            cmd.Parameters.AddWithValue("@emailcim", Program.VasarlokUpdate.textBox_emailcim.Text);
            cmd.Parameters.AddWithValue("@felhasznalonev", Program.VasarlokUpdate.textBox_felhasznalonev.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public bool VasarlokDelete(Vasarlo konyvekDelete)
        {

            cmd.CommandText = "DELETE FROM `vasarlo` WHERE `vasarloid` = @vasarloid;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@vasarloid", Program.vasarlokDelete.textBox_vasarloid.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
