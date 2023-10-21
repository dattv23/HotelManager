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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private bool checkInput()
        {
            if (txtPhoneNo.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please fill full all field!");
                return false;
            }
            if (!txtPhoneNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("The phone number must be a string of numbers");
                return false;
            }
            return true;
        }

        private async Task<bool> findAccount(String phoneNumber, String username)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonAccount = JsonConvert.SerializeObject(new
                    {
                        phone = phoneNumber,
                        username = username
                    });
                    StringContent content = new StringContent(jsonAccount, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:3000/findAccount", content);

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

        private async void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput())
                {
                    bool resultFindAccount = await findAccount(txtPhoneNo.Text, txtUsername.Text);
                    if (!resultFindAccount)
                    {
                        MessageBox.Show("Account not found!", "Error");
                        return;
                    } else
                    {
                        this.Hide();
                        FormNewPassword frm = new FormNewPassword(txtPhoneNo.Text, txtUsername.Text);
                        frm.Show();
                    }
                } else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
