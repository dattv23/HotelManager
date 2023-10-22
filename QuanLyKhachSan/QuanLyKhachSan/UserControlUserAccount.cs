using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using static DevExpress.XtraEditors.Mask.MaskSettings;
//using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuanLyKhachSan
{
    public partial class UserControlUserAccount : UserControl
    {
        List<User> users;
        private async Task<string> FindUser(string phoneNumber)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string UrlAPI = "http://localhost:3000";
                    string apiUrl = $"{UrlAPI}/getUserByPhone/{phoneNumber}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        
                        return jsonResponse;
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Phone not found.");

                        dgvUser.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve user data: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public async Task<string> getData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:3000/users");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        return jsonResponse;
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve user data. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void reset()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtGmail.Text = "";
            txtphone.Text = "";
            txtGmail.Text = "";
            txtAddress.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        public async void loadDGV()
        {
            users = JsonConvert.DeserializeObject<List<User>>(await getData());
            int index = 1;
            string permission = "";
            dgvUser.Rows.Clear();
            foreach (var item in users)
            {
                if (item.accountType == 0) permission = "Client";
                else if (item.accountType == 1) permission = "Member";
                else if (item.accountType == 2) permission = "Manager";
                dgvUser.Rows.Add(index, item.name, item.phone, item.email, item.address, permission);
                permission = "";
                index++;
            }
        }

        public UserControlUserAccount()
        {
            InitializeComponent();
            loadDGV();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digits long.");
                return false;
            }

            if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone number can only contain numeric digits.");
                return false;
            }

            return true;
        }

        private bool ValidateInput(string firstName, string username, string lastName, string email, string address, string password, string phoneNumber)
        {
            if (firstName == "" || lastName == "" || username == "" || password == "" || phoneNumber == "" || email == "" || address == "")
            {
                MessageBox.Show("Please complete all information!");
                return false;
            }
            else
            {
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email address!");
                    return false;
                }

                if (!IsValidPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Invalid phone number!");
                    return false;
                }
            }
            return true;
        }
        public async Task<string> addUser(object user)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonUser = JsonConvert.SerializeObject(user);
                    StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:3000/users", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        return res;
                    }
                    else
                    {
                        MessageBox.Show($"Add user failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private async Task<bool> updateUser(object user)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonUser = JsonConvert.SerializeObject(user);
                    StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");

                    // Assuming you have the user's _id available (replace "userId" with the actual property name)
                    HttpResponseMessage response = await client.PutAsync("http://127.0.0.1:3000/users", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Update failed. Status code: {response.StatusCode}");
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private async Task<bool> deleteUser(string phoneNumber)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    // Assuming you have the user's _id available (replace "userId" with the actual property name)
                    HttpResponseMessage response = await client.DeleteAsync($"http://127.0.0.1:3000/users?phone={phoneNumber}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User delete successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Delete failed. Status code: {response.StatusCode}");
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string email = txtGmail.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtphone.Text;
            string password = txtPassword.Text;
            int accountType = cbxAccType.SelectedIndex;

            if (!ValidateInput(firstName, lastName, username, email, address, password, phoneNumber))
            {
                return;
            }

            var newUser = new
            {
                name = firstName + " " + lastName,
                phone = phoneNumber,
                email = email,
                address = address,
                accountType = accountType, // 0: Client, 1: Member, 2: Mananger
                account = new
                {
                    username = username,
                    password = password,
                    status = 0 // 0: NotActive, 1: Active
                }
            };

            string res = await addUser(newUser);
            if (res == null)
            {
                MessageBox.Show("Add user failed!");
            }
            else
            {
                MessageBox.Show("Add user successed!");
                loadDGV();
                reset();
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            string res = await FindUser(txtPhoneNo.Text);
            List<User> userList = JsonConvert.DeserializeObject<List<User>>(res);

            // Xóa sạch DataGridView trước khi hiển thị kết quả tìm kiếm
            dgvUser.Rows.Clear();

            string permission = "";
            foreach (var item in userList)
            {
                if (item.accountType == 0) permission = "Client";
                else if (item.accountType == 1) permission = "Member";
                else if (item.accountType == 2) permission = "Manager";
                int index = dgvUser.Rows.Add();
                dgvUser.Rows[index].Cells[0].Value = index + 1;
                dgvUser.Rows[index].Cells[1].Value = item.name;
                dgvUser.Rows[index].Cells[2].Value = item.phone;
                dgvUser.Rows[index].Cells[3].Value = item.email;
                dgvUser.Rows[index].Cells[4].Value = item.address;
                dgvUser.Rows[index].Cells[5].Value = permission;

            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text == "")
            {
                loadDGV();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName2.Text;
            string lastName = txtLastName2.Text;
            string username = txtUsername2.Text;
            string email = txtGmail2.Text;
            string address = txtAddress2.Text;
            string phoneNumber = txtphone2.Text;
            string password = txtPassword2.Text;
            int accountType = cbAccType2.SelectedIndex;

            if (!ValidateInput(firstName, lastName, username, email, address, password, phoneNumber))
            {
                return;
            }

            var newUser = new
            {
                name = firstName + " " + lastName,
                phone = phoneNumber,
                email = email,
                address = address,
                accountType = accountType, // 0: Client, 1: Member, 2: Mananger
                account = new
                {
                    username = username,
                    password = password,
                    status = 0 // 0: NotActive, 1: Active
                }
            };
            await updateUser(newUser);
            loadDGV();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtphone2.Text == "")
            {
                MessageBox.Show("Please fill phone number to delete!", "Error");
            } else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Người dùng đã chọn Yes, thực hiện xóa
                    await deleteUser(txtphone2.Text);
                    loadDGV();
                }
            }
        }

        public void resetInput2()
        {
            txtFirstName2.Text = "";
            txtLastName2.Text = "";
            txtUsername2.Text = "";
            txtPassword2.Text = "";
            txtGmail2.Text = "";
            txtAddress2.Text = "";
        }

        private  void txtphone2_TextChanged(object sender, EventArgs e)
        {
            if (txtphone2.Text == "")
            {

            }
            foreach (var item in users)
            {
                if (item.phone == txtphone2.Text)
                {
                    string name = item.name;
                    if (name.Split(' ').Length > 1)
                    {
                        txtFirstName2.Text = name.Substring(0, name.LastIndexOf(' '));
                        txtLastName2.Text = name.Substring(name.LastIndexOf(' ') + 1);
                    } else
                    {
                        txtLastName2.Text = name;
                    }
                    txtGmail2.Text = item.email;
                    txtAddress2.Text = item.address;
                    if (item.acccount != null)
                    {
                        txtUsername2.Text = item.acccount.username;
                        txtPassword2.Text = item.acccount.password;
                    }
                    cbAccType2.SelectedIndex = item.accountType;
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
