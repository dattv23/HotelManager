using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuanLyKhachSan
{
    public partial class FormLogin : Form


    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMinimize, "Minimize");
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picClose, "Close");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async Task<string> login(String userName, String passWord)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var account = new
                    {
                        username = userName,
                        password = passWord
                    };
                    string jsonAccount= JsonConvert.SerializeObject(account);
                    StringContent content = new StringContent(jsonAccount, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:3000/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        return res;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool checkInput()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill full field!");
                return false;
            } 
            return true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool check = checkInput();
            if (!check) return;

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var resultLogin = await login(username, password);
            if (resultLogin == null)
            {
                MessageBox.Show("Login failed!", "Error");
                return;
            }
            JObject jsonObject = JObject.Parse(resultLogin);
            string accountType = jsonObject["accountType"].ToString();
            if (int.Parse(accountType) == 1)
            {
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.Username = txtUsername.Text;
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
                formDashboard.Show();
            } else if (int.Parse(accountType) == 2)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Username = txtUsername.Text;
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
                formAdmin.Show();
            }
        }
        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Show Password");
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picHide, "Hide Password");

        }

        private void picShow_Click(object sender, EventArgs e)
        {
            picShow.Hide();
            txtPassword.UseSystemPasswordChar = false;
            picHide.Show();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            picHide.Hide();
            txtPassword.UseSystemPasswordChar = true;
            picShow.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormForgotPassword frm = new FormForgotPassword();
            frm.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPassword frm = new FormForgotPassword();
            frm.Show();
        }
    }
}
