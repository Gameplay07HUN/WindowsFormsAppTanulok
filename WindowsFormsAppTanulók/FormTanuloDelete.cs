using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppTanulók
{
    public partial class FormTanuloDelete : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public FormTanuloDelete()
        {
            InitializeComponent();
        }
        private void Adatbetölt()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "a program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
        }
        private void gyumolcs_lista_update()
        {
            listBoxGyumolcsok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Gyumolcs uj = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetInt32("egysegar"), dr.GetInt32("mennyiseg"));
                    listBoxGyumolcsok.Items.Add(uj);
                }
            }
            conn.Close();
        }
        private void FormTanuloDelete_Load(object sender, EventArgs e)
        {
            Adatbetölt();
            gyumolcs_lista_update();
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (listBoxGyumolcsok.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `gyumolcsok` WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxAzonosito.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres!");
                conn.Close();
                textBoxAzonosito.Text = "";
                textBoxGyumolcsnev.Text = "";
                numericUpDownEgysegar.Value = numericUpDownEgysegar.Minimum;
                numericUpDownMennyiseg.Value = numericUpDownMennyiseg.Minimum;
                gyumolcs_lista_update();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen!");
            }
        }

        private void listBoxGyumolcsok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGyumolcsok.SelectedIndex < 0)
            {
                return;
            }
            Gyumolcs kivalaszott_gumolcs = (Gyumolcs)listBoxGyumolcsok.SelectedItem;
            textBoxAzonosito.Text = kivalaszott_gumolcs.Id.ToString();
            textBoxGyumolcsnev.Text = kivalaszott_gumolcs.Nev;
            numericUpDownEgysegar.Value = (decimal)kivalaszott_gumolcs.Egysegar;
            numericUpDownMennyiseg.Value = (decimal)kivalaszott_gumolcs.Mennyiseg;
        }
    }
}
