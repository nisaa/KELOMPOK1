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
    public partial class FormLogin : Form
    {
        private string address = Properties.Settings.Default.DbBioskopConnectionString;

        DashboardManajerial dashboardManajerial;
        DashboardBackOffice dashboardBackOffice;
        DashboardFrontOffice dashboardFrontOffice;
        
        Login login;
        
        public FormLogin()
        {
            InitializeComponent();
            login = new Login();

            this.FormClosed += new FormClosedEventHandler(ExitApp);
        }

        private void Login()
        {

            SqlConnection connection = new SqlConnection(address);

            using (connection)
            {
                connection.Open();

                string query = "SELECT nama, hak_akses FROM pegawai WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                DataRow[] dataLogin = table.Select();

                int userExist = dataLogin.Count();

                if (userExist == 0)
                {
                    string title = "Kesalahan";
                    string message = "Username dan password tidak sesuai!";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string aksesLevel = dataLogin[0]["hak_akses"].ToString();

                    if (aksesLevel == "3")
                    {
                        dashboardManajerial = new DashboardManajerial();

                        dashboardManajerial.FormClosed += new FormClosedEventHandler(ExitApp);
                        dashboardManajerial.Visible = true;
                    }
                    else if (aksesLevel == "2")
                    {
                        dashboardBackOffice = new DashboardBackOffice(dataLogin);

                        dashboardBackOffice.FormClosed += new FormClosedEventHandler(ExitApp);
                        dashboardBackOffice.Visible = true;
                    }
                    else
                    {
                        dashboardFrontOffice = new DashboardFrontOffice();
                        
                        dashboardFrontOffice.FormClosed += new FormClosedEventHandler(ExitApp);
                        dashboardFrontOffice.Visible = true;
                    }

                    this.Hide();

                }

                connection.Close();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (login.SetLogin(textBoxUsername.Text, textBoxPassword.Text) == false)
            {
                string title = "Kesalahan";
                string message = "Username dan password harus diisi!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                Login();

            textBoxUsername.Clear();
            textBoxPassword.Clear();

            textBoxUsername.Select();
        }
        public void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
