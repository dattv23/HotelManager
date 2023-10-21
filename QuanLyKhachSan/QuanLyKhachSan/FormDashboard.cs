using DevExpress.Utils.MVVM;
using DevExpress.Xpo.DB;
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
   
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
            
        }
        private void movepanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd-MMMMMM-yyyy hh:mm:ss tt");

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
           timer1.Start();
          lblUsername.Text = Username;
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        // Hàm kiểm tra màu có hợp lệ hay không
        private bool IsValidColor(string colorName)
        {
            try
            {
                Color color = Color.FromName(colorName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hàm kiểm tra font chữ có hợp lệ hay không
        private bool IsValidFont(string fontName)
        {
            FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                if (string.Equals(fontFamily.Name, fontName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            movepanel(btnDashboard);
            lblUsername.Text = Username;
            // Lấy giá trị cài đặt màu nền từ cài đặt ứng dụng đã lưu
            string backgroundColor = Properties.Settings.Default.BackgroundColor;

            // Kiểm tra xem giá trị đã lưu có hợp lệ không (ví dụ: nếu màu đã lưu không tồn tại, sử dụng màu mặc định)
            if (IsValidColor(backgroundColor))
            {
                // Áp dụng màu nền đã lưu cho form chính
                this.BackColor = Color.FromName(backgroundColor);
            }
            else
            {
                // Sử dụng màu mặc định nếu giá trị không hợp lệ
                this.BackColor = Color.White; // Màu nền mặc định
            }

            // Lấy giá trị cài đặt font chữ từ cài đặt ứng dụng đã lưu
            string fontName = Properties.Settings.Default.FontName;

            // Kiểm tra xem giá trị đã lưu có hợp lệ không (ví dụ: nếu font đã lưu không tồn tại, sử dụng font mặc định)
            if (IsValidFont(fontName))
            {
                // Áp dụng font chữ đã lưu cho form chính
                this.Font = new Font(fontName, 12);
            }
            else
            {
                // Sử dụng font mặc định nếu giá trị không hợp lệ
                this.Font = new Font("Arial", 12); // Font mặc định
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            movepanel(btnDashboard);
            userControlSetting1.Hide();
            userControlReservation1.Hide();
            userControlRoom1.Hide();
            userControlClient1.Hide();
          userControlDashBoard12.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            movepanel(btnClient);
            userControlSetting1.Hide();
            userControlReservation1.Hide();
            userControlRoom1.Hide();
            userControlClient1.Show();
            userControlDashBoard12.Hide();
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            movepanel(btnRoom);
            userControlSetting1.Hide();
            userControlReservation1.Hide();
            userControlRoom1.Show();
            userControlClient1.Hide();
            userControlDashBoard12.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            movepanel(btnReservation);
            userControlSetting1.Hide();
            userControlReservation1.Show();
            userControlRoom1.Hide();
            userControlClient1.Hide();
            userControlDashBoard12.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            movepanel(btnSetting);
            UserControlSetting userControlSetting = new UserControlSetting();
            userControlSetting.Clear();
            userControlSetting1.Show();
            userControlReservation1.Hide();
            userControlRoom1.Hide();
            userControlDashBoard12.Hide();
        }

        private void linkLabelLogOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
           
            FormAdmin frm = new FormAdmin();
            frm.Show();
           
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();   
            frm.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            movepanel(btnPayment);
            FormPayment formchild = new FormPayment();
            formchild.ShowDialog();
        }
    }
}
