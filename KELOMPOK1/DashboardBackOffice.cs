using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KELOMPOK1
{
    public partial class DashboardBackOffice : Form
    {
        string address = Properties.Settings.Default.DbBioskopConnectionString;
        
        public DashboardBackOffice(DataRow[] data)
        {
            InitializeComponent();

            bindDatabase();

            labelNamaPegawai.Text = data[0]["nama"].ToString();
            labelJumlahStudio.Text = dataGridStudio.RowCount.ToString() + " STUDIO";
            labelTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = false;
        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = true;
            panelStudio.Visible = false;
        }

        private void buttonStudio_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = true;
            panelStudio.Visible = true;
            panelShow.Visible = false;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = true;
            panelStudio.Visible = true;
            panelShow.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            this.Hide();
            
            formLogin.Visible = true;
        }

        private void bindDatabase()
        {
            SqlConnection connection = new SqlConnection(address);

            using (connection)
            {
                connection.Open();

                string query = "SELECT * FROM studio";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridStudio.DataSource = table;

                dataGridStudio.Columns[0].HeaderText = "Nomor Studio";
                dataGridStudio.Columns[1].HeaderText = "Jumlah Baris";
                dataGridStudio.Columns[2].HeaderText = "Jumlah Kursi per Baris";
                dataGridStudio.Columns[3].HeaderText = "Kapasitas";
                dataGridStudio.Columns[4].HeaderText = "Tipe";

                connection.Close();
            }
        }
    }
}
