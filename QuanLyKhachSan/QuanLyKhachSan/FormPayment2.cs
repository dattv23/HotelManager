using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;
using Font = iTextSharp.text.Font;

namespace QuanLyKhachSan
{
    public partial class FormPayment2 : Form
    {
        string phoneNumber;
        string reservationNumber;
        DateTime checkin;
        DateTime checkout;

        public async void loadData()
        {
            List<User> userList = JsonConvert.DeserializeObject<List<User>>(await FindUser(phoneNumber));
            foreach (var item in userList)
            {
                string name = item.name;
                txtFirstName.Text = name.Substring(0, name.LastIndexOf(' '));
                txtLastName.Text = name.Substring(name.LastIndexOf(' ') + 1);
                txtphone.Text = phoneNumber;
                txtEmail.Text = item.email;
                txtAddress.Text = item.address;
            }
        }
        public FormPayment2(string phoneNumber, string reservationNumber, DateTime checkin, DateTime checkout, double amount)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            this.reservationNumber = reservationNumber;
            this.checkin = checkin;
            this.checkout = checkout;
            lblTotalAmount.Text = amount.ToString();
            loadData();
        }

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

        public int getValueRDB()
        {
            if (rdbCash.Checked) return 0;
            if (rdbTransfer.Checked) return 1;
            if (rdbCreditCard.Checked) return 2;
            return 0;
        }

        private async Task<bool> SavePayment()
        {
            try
            {
                if (!rdbCash.Checked && !rdbTransfer.Checked && !rdbCreditCard.Checked) { MessageBox.Show("Please select payment method!"); return false; }
                var content = new StringContent(JsonConvert.SerializeObject(new BillTransaction()
                {
                    creationDate = DateTime.Now,
                    amount = double.Parse(lblTotalAmount.Text),
                    status = 1, // 0.Unpaid, 1. Paid
                    method = getValueRDB(), // 0.CreditCard, 1.CheckTransaction, 2. CashTransaction
                    reservationNumber = reservationNumber
                }), Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.PostAsync("http://127.0.0.1:3000/billtransactions", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Payment saved successfully.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Payment not saved successfully.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CreateInvoicePDF()
        {
            string directoryPath = @"D:\HUTECH_IT\LapTrinhWinform\BillTransaction";

            Directory.CreateDirectory(directoryPath);

            string pdfFileName = Path.Combine(directoryPath, $"Invoice{reservationNumber}.pdf");
            Document document = new Document();

            try
            {
                if (File.Exists(pdfFileName))
                {
                    // Nếu tệp đã tồn tại, thay thế nó bằng cách xóa tệp cũ trước khi tạo tệp mới
                    File.Delete(pdfFileName);
                }

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFileName, FileMode.Create));
                document.Open();

                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20f);

                // Tiêu đề hóa đơn
                Paragraph title = new Paragraph("Invoice", titleFont); // Sử dụng titleFont đã được đặt đậm
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Thông tin hóa đơn
                Font infoFont = FontFactory.GetFont(FontFactory.HELVETICA, 12f);

                document.Add(new Paragraph("Reservation Number: " + reservationNumber, infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Check In: " + checkin.ToString("dd/MM/yyyy"), infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Check Out: " + checkout.ToString("dd/MM/yyyy"), infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Name: " + txtFirstName.Text + " " + txtLastName.Text, infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Phone: " + txtphone.Text, infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Email: " + txtEmail.Text, infoFont)); // Sử dụng infoFont
                string methodPay = getValueRDB() == 0 ? "Cash" : (getValueRDB() == 1) ? "Tranfer" : "CreditCard";
                document.Add(new Paragraph("Method payment: " + methodPay, infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Create at: " + DateTime.Now.ToString("dd/MM/yyyy"), infoFont)); // Sử dụng infoFont
                document.Add(new Paragraph("Total Amount: " + lblTotalAmount.Text, infoFont)); // Sử dụng infoFont

                document.Close();
                MessageBox.Show("Created or replaced PDF invoice");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating or replacing PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!rdbCash.Checked && !rdbTransfer.Checked && !rdbCreditCard.Checked) { MessageBox.Show("Please select payment method!"); return; }
            CreateInvoicePDF();
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            await SavePayment();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
