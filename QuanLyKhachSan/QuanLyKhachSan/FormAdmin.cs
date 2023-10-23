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
    public partial class FormAdmin : Form
    {
        public string Username;
        private UserControl currentControl = null;
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void movepanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Log Out? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                //FormLogin formLogin = new FormLogin();
                this.Close();
                //formLogin.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsername.Text = Username;
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            movepanel(btnUserAccount);
            currentControl = userControlUserAccount1;
            userControlUserAccount1.Show();
            userControlStatistic1.Hide();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            movepanel(btnStatistic);
            currentControl = userControlStatistic1;
            userControlUserAccount1.Hide();
            userControlStatistic1.Show();
        }

        private void btnFormDashboard_Click(object sender, EventArgs e)
        {
            movepanel(btnUserAccount);
            FormDashboard formchild = new FormDashboard();
            formchild.ShowDialog();
            if (currentControl == userControlUserAccount1)
            {
                movepanel(btnUserAccount);
            }
            else if (currentControl == userControlStatistic1)
            {
                movepanel(btnStatistic);
            }
        }
    }
}
  
