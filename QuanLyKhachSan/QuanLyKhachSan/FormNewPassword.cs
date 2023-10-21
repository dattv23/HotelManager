using Newtonsoft.Json;
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

namespace QuanLyKhachSan
{
    public partial class FormNewPassword : Form
    {
        private string phoneNumber = "";
        private string username = "";
        public FormNewPassword(string phoneNumber, string username)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            this.username = username;
        }

        private async Task<bool> resetPass(String phoneNumber, String username, string newPass)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonAccount = JsonConvert.SerializeObject(new
                    {
                        phonenumber = phoneNumber,
                        username = username,
                        newPassword = newPass
                    });
                    StringContent content = new StringContent(jsonAccount, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:3000/resetPassword", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormForgotPassword formForgot = new FormForgotPassword();
            formForgot.Show();
        }

        private bool checkPass()
        {
            if (txtNewPassWord.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill full all field!");
                return false;
            }
            if (txtConfirmPassword.Text != txtNewPassWord.Text)
            {
                MessageBox.Show("Password not match!");
                return false;
            }
            return true;
        }

        private async void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkPass())
                {
                    bool result = await resetPass(phoneNumber, username, txtNewPassWord.Text);
                    if (result)
                    {
                        MessageBox.Show("Update password successed!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Update password failed!");
                        this.Hide();
                        FormForgotPassword formForgotPassword = new FormForgotPassword();   
                        formForgotPassword.Show();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
