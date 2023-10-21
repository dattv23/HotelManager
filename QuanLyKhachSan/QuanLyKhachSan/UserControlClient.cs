using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraExport.Xls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using QuanLyKhachSan.Model;
using DevExpress.XtraRichEdit.Fields;
//using static DevExpress.XtraEditors.Mask.MaskSettings;
//using DevExpress.XtraPrinting.Native.WebClientUIControl;

namespace QuanLyKhachSan
{
    public partial class UserControlClient : UserControl
    {
        string urlApi = "http://localhost:3000/users";
        private async Task<string> LoadData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(urlApi);

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
        private async Task<string> AddUserAsync(User user)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonUser = JsonConvert.SerializeObject(user);
                    StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(urlApi, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        return res;
                    }
                    else
                    {
                        MessageBox.Show($"Phone number is duplicated, please enter a different number");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private async Task<bool> UpdateUser(User user)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonUser = JsonConvert.SerializeObject(user);
                    StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");

                    // Assuming you have the user's _id available (replace "userId" with the actual property name)
                    HttpResponseMessage response = await client.PutAsync(urlApi, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the success case here (e.g., display a success message)
                        MessageBox.Show("User updated successfully!");

                        // Reload the data in the DataGridView to reflect the changes
                        await LoadData();

                    }
                    else
                    {
                        MessageBox.Show($"Update failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private async Task<bool> DeleteUserByPhone(string phone)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Construct the URL with the phone number as a query parameter
                    string apiUrl = $"{urlApi}?phone={phone}";

                    // Send a DELETE request to the constructed URL
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the success case here (e.g., display a success message)
                        MessageBox.Show("User deleted successfully!");

                        // Reload the data in the DataGridView to reflect the changes
                        //await LoadData();
                        return true;
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("User not found.");
                    }
                    else
                    {
                        MessageBox.Show($"Delete failed. Status code: {response.StatusCode}");
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private async Task<List<User>> FindUser(string phoneNumber)
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
                        List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonResponse);

                        // Xóa sạch DataGridView trước khi hiển thị kết quả tìm kiếm
                        dgvUser.Rows.Clear();

                        foreach (var item in userList)
                        {
                            int index = dgvUser.Rows.Add();
                            dgvUser.Rows[index].Cells[0].Value = 1;
                            dgvUser.Rows[index].Cells[1].Value = item.name;
                            dgvUser.Rows[index].Cells[2].Value = item.phone;
                            dgvUser.Rows[index].Cells[3].Value = item.email;
                            dgvUser.Rows[index].Cells[4].Value = item.address;

                        }
                        return userList;
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Phone not found.");

                        // Clear the DataGridView if the search returns no results
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

        public void reset()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtphone.Text = "";
        }

        public void resetUp()
        {
            txtFirstNameUp.Text = "";
            txtLastNameUp.Text = "";
            txtEmailUp.Text = "";
            txtAddressUp.Text = "";
            txtPhoneUp.Text = "";
        }

        public UserControlClient()
        {
            InitializeComponent();
            loadDGV();
        }
        public async void loadDGV()
        {
            List<User> userList = JsonConvert.DeserializeObject<List<User>>(await LoadData());
            int ID = 1;

            dgvUser.Rows.Clear();

            foreach (var item in userList)
            {
                if (item.accountType == 0)
                {
                    int index = dgvUser.Rows.Add();
                    dgvUser.Rows[index].Cells[0].Value = ID;
                    dgvUser.Rows[index].Cells[1].Value = item.name;
                    dgvUser.Rows[index].Cells[2].Value = item.phone;
                    dgvUser.Rows[index].Cells[3].Value = item.email;
                    dgvUser.Rows[index].Cells[4].Value = item.address;
                    ID++;
                }
            }
            return ;
        }

        private bool ValidateInput(string firstName, string lastName, string email, string address, string phoneNumber)
        {
            if (!Validator.IsValidFirstName(firstName))
            {
                MessageBox.Show("First name is invalid. First name should be a string!", "Error");
                return false;
            }

            if (!Validator.IsValidLastName(lastName))
            {
                MessageBox.Show("Last name is invalid. Last name should be a string!", "Error");
                return false;
            }

            if (!Validator.IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone Number is invalid. Phone should be a string of 10 numbers!", "Error");
                return false;
            }

            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email is invalid.", "Error");
                return false;
            }

            if (!Validator.IsValidAddress(address))
            {
                MessageBox.Show("Address is invalid.", "Error");
                return false;
            }

            return true;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtphone.Text;

            bool resultCheck = ValidateInput(firstName, lastName, email, address, phoneNumber);

            if (resultCheck)
            {
                try
                {
                    string res = await AddUserAsync(new User(firstName+" "+lastName, phoneNumber, email, address, 0, null));
                    if (res == null)
                    {
                        MessageBox.Show("Add user failed!", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Add user successed!", "Notification");
                        loadDGV();
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                    throw;
                }
            }
            return;
        }
        private async void btnFind_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSearchClient.Text.Trim();
            if(string.IsNullOrEmpty(phoneNumber))
            {
                loadDGV();
            }
            else
            {
                dgvUser.Rows.Clear();
                List<User> user = await FindUser(phoneNumber);

                if (user == null || user.Count == 0)
                {
                    MessageBox.Show("Phone not found.");
                }
            }       
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstNameUp.Text;
            string lastName = txtLastNameUp.Text;
            string email = txtEmailUp.Text;
            string address = txtAddressUp.Text;
            string phoneNumber = txtPhoneUp.Text;

            bool resultCheck = ValidateInput(firstName, lastName, email, address, phoneNumber);

            if (resultCheck)
            {
                try
                {
                    await UpdateUser(new User(firstName + " " +lastName, phoneNumber, email, address, 0, null));
                    resetUp();
                    loadDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                    throw;
                }
            }

        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
 
            string phoneNumber = txtPhoneUp.Text;

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            if (!Validator.IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone Number is invalid.");
                return;
            }


            await DeleteUserByPhone(phoneNumber);
            loadDGV();
            resetUp();
        }
        private void txtPhoneUp_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPhoneUp.Text, out int phoneNumber))
            {
                // Tìm thông tin user từ data source (e.g., dgvUsers)
                foreach (DataGridViewRow row in dgvUser.Rows)
                {
                    if (row.Cells[2].Value != null && Convert.ToInt32(row.Cells[2].Value) == phoneNumber)
                    {
                        // Lấy thông tin user từ dgvUsers
                        string Name = row.Cells[1].Value.ToString();
                        string email = row.Cells[3].Value.ToString();
                        string address = row.Cells[4].Value.ToString();

                        // Cập nhật các controls trong tabControlUpdateAndDelete
                        txtFirstNameUp.Text = Name.Substring(0, Name.LastIndexOf(' '));
                        txtLastNameUp.Text = Name.Substring(Name.LastIndexOf(' ')+1);
                        txtEmailUp.Text = email;
                        txtAddressUp.Text = address;
                        return;
                    }
                }

                // If the phone number is not found, clear the controls
                txtFirstNameUp.Clear();
                txtLastNameUp.Clear();
                txtEmailUp.Clear();
                txtAddressUp.Clear();
            }
            else
            {
                // Handle the case when the entered text is not a valid phone number (not an integer)
                // You can show an error message or take appropriate action.
            }
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchClient.Text == "")
            {
                loadDGV();
            }
        }
    }
}


