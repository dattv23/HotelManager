using RestSharp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class UserControlSetting : UserControl
    {
       
        public UserControlSetting()
        {
            InitializeComponent();
        }
        public void Clear()
        {
           
        }
        public void Clear2()
        {
           
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            //txtSearchUserName.Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
          
        }

        private void tabPageUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear2();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {
            cmbColor.Items.Add("Red");
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Green");

            // Thiết lập danh sách font chữ
            cmbFont.Items.Add("Arial");
            cmbFont.Items.Add("Times New Roman");
            cmbFont.Items.Add("Verdana");

            // Thiết lập danh sách ngôn ngữ
            
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            string selectedColor = cmbColor.SelectedItem.ToString();
            string selectedFontName = cmbColor.SelectedItem.ToString();
            string selectedLanguage = cmbColor.SelectedItem.ToString();

            // Lưu các thay đổi vào cài đặt ứng dụng của bạn (ví dụ: sử dụng Properties.Settings.Default)
            Properties.Settings.Default.BackgroundColor = selectedColor;
            Properties.Settings.Default.FontName = selectedFontName;
            Properties.Settings.Default.Language = selectedLanguage;
            Properties.Settings.Default.Save();

            // Đóng form Setting
          
        }

       

        private void btnHuySetting_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
