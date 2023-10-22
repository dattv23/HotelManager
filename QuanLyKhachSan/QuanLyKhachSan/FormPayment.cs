using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using DevExpress.XtraCharts.Designer.Native;

namespace QuanLyKhachSan
{
    public partial class FormPayment : Form
    {
        List<RoomBooking> bookings;
        List<Room> rooms;
        List<BillTransaction> billTransactions;
        string reservationNumber = "";
        double price = 0;
        public FormPayment()
        {
            InitializeComponent();
        }

        public string roomStyle(int number)
        {
            switch (number)
            {
                case 0:
                    return "Standard";
                case 1:
                    return "Deluxe";
                case 2:
                    return "Family";
                case 3:
                    return "Business";
            }
            return null;
        }

        private async Task<string> getDataRoom()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/rooms");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        return jsonResponse;
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve room data: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private async Task<string> getDataBillTransactions()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/billtransactions");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        return jsonResponse;
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve room data: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        public async Task<string> getDataBooking()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/bookings");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        return jsonResponse;
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve booking data. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public double getPriceBookingRoom(List<Room> rooms, int roomnumber)
        {
            foreach (var item in rooms)
            {
                if (item.roomNumber == roomnumber) return item.bookingPrice;
            }
            return 0;
        }

        public bool checkReservationUnpaid(string reservationNumber)
        {
            foreach (var item in billTransactions)
            {
                if (item.reservationNumber == reservationNumber && item.status == 1)
                {
                    return false;
                }
            }
            return true;
        }

        private void loadDGV(List<RoomBooking> lBooking)
        {
            dgvPayment.Rows.Clear();
            double amount = 0;
            foreach (var item in lBooking)
            {
                if (item.startDate < DateTime.Now && checkReservationUnpaid(item.reservationNumber))
                {
                    amount = ((item.checkout - item.checkin).Days + 1) * getPriceBookingRoom(rooms, item.roomNumber);
                    dgvPayment.Rows.Add(item.reservationNumber, item.phoneNumber, item.roomNumber, roomStyle(item.style), item.startDate, amount);
                }
            }
        }

        private async void FormPayment_Load(object sender, EventArgs e)
        {
            bookings = JsonConvert.DeserializeObject<List<RoomBooking>>((await getDataBooking()));
            rooms = JsonConvert.DeserializeObject<List<Room>>((await getDataRoom()));
            billTransactions = JsonConvert.DeserializeObject<List<BillTransaction>>((await getDataBillTransactions()));
            loadDGV(bookings);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validator.IsValidPhoneNumber(txtPhoneNo.Text))
                {
                    MessageBox.Show("Phone number is not valid!", "Error");
                    return;
                }
                dgvPayment.Rows.Clear();
                List<RoomBooking> roomBookings = new List<RoomBooking>();
                foreach (var item in bookings)
                {
                    if (item.phoneNumber == txtPhoneNo.Text)
                    {
                        roomBookings.Add(item);
                    }
                }
                loadDGV(roomBookings);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text == "")
            {
                loadDGV(bookings);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validator.IsValidPhoneNumber(txtPhoneNo.Text))
                {
                    MessageBox.Show("Phone number is not valid!", "Error");
                    return;
                }
                DateTime checkinDate = DateTime.MinValue; // Ngày nhận phòng
                DateTime checkoutDate = DateTime.MinValue; // Ngày trả phòng
                foreach (var item in bookings)
                {
                    if (item.phoneNumber == txtPhoneNo.Text)
                    {
                        price = (item.checkout - item.checkin).Days * getPriceBookingRoom(rooms, item.roomNumber);
                        reservationNumber = item.reservationNumber;
                        checkinDate = item.checkin;
                        checkoutDate = item.checkout;
                    }
                }
                if (checkinDate != DateTime.MinValue && checkoutDate != DateTime.MinValue)
                {
                    FormPayment2 formPayment2 = new FormPayment2(txtPhoneNo.Text, reservationNumber, checkinDate, checkoutDate, price);
                    formPayment2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No booking found for the provided phone number.", "Error");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
