using DevExpress.XtraRichEdit.Fields;
using Newtonsoft.Json;
using QuanLyKhachSan.Model;
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
    public partial class UserControlDashBoard1 : UserControl
    {
        public async Task<string> getDataUser()
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

        public async Task<string> getDataRoom()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:3000/rooms");

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

        public async void loadData()
        {
            List<User> lUser = JsonConvert.DeserializeObject<List<User>>(await getDataUser());
            int countClient = 0;
            foreach (var item in lUser)
            {
                if (item.accountType == 0) { countClient++; }
            }
            lbClient.Text = countClient.ToString(); 
            lbMember.Text = (lUser.Count - countClient).ToString();
            List<Room> lRoom = JsonConvert.DeserializeObject<List<Room>>(await getDataRoom());
            lbRoom.Text = (lRoom.Count).ToString();
        }

        public UserControlDashBoard1()
        {
            InitializeComponent();
            loadData();
        }
    }
}
