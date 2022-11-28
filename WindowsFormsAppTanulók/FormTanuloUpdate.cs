using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppTanulók
{
    public partial class FormTanuloUpdate : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
            public FormTanuloUpdate()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
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

        private void FormTanuloUpdate_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Program.formNyito.textBoxNev.Text + " adatainak módosítása");
            gyumolcs_lista_update();
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

        private void buttonModosítas_Click(object sender, EventArgs e)
        {
            if (listBoxGyumolcsok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve gyümölcs!");
                return;
            }
            cmd.CommandText = "UPDATE `gyumolcsok` SET `nev` = @nev, `egysegar` = @egysegar, `mennyiseg` = @mennyiseg WHERE `gyumolcsok`.`id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxAzonosito.Text);
            cmd.Parameters.AddWithValue("@nev", textBoxGyumolcsnev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDownEgysegar.Value);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDownMennyiseg.Value);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres!");
                conn.Close();
                textBoxAzonosito.Text = "";
                textBoxGyumolcsnev.Text = "";
                numericUpDownEgysegar.Value = numericUpDownEgysegar.Minimum;
                numericUpDownMennyiseg.Value = numericUpDownMennyiseg.Minimum;
                gyumolcs_lista_update();
            }
            else
            {
                MessageBox.Show("Az adatok modosítása sikerleten!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }
}
