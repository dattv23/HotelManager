using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using DevExpress.Utils.MVVM;
using DevExpress.Xpo.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using Newtonsoft.Json;
using GLib;
using DevExpress.XtraRichEdit.Fields;
using DateTime = System.DateTime;
using DevExpress.CodeParser;

namespace QuanLyKhachSan
{
    public partial class UserControlReservation : UserControl
    {
        public async void loadDGV()
        {
            List<RoomBooking> lRoomBooking = JsonConvert.DeserializeObject<List<RoomBooking>>(await getDataBooking());
            int ID = 1;

            dgvReservation.Rows.Clear();

            foreach (var item in lRoomBooking)
            {
                dgvReservation.Rows.Add(ID++, item.roomNumber, item.phoneNumber, item.checkin.ToString("dd/MM/yyyy"), item.checkout.ToString("dd/MM/yyyy"));
            }
            return;
        }

        public async void loadCBRoomNo()
        {
            List<Room> lRoom = JsonConvert.DeserializeObject<List<Room>>(await getDataRoom());
            cbxNo.Items.Clear();
            foreach (var item in lRoom)
            {
                cbxNo.Items.Add(item.roomNumber);
            }
        }

        public async void loadCBRoomNo2()
        {
            List<Room> lRoom = JsonConvert.DeserializeObject<List<Room>>(await getDataRoom());
            cbxNo2.Items.Clear();
            foreach (var item in lRoom)
            {
                cbxNo2.Items.Add(item.roomNumber);
            }
        }

        public UserControlReservation()
        {
            InitializeComponent();
            loadDGV();
            loadCBRoomNo();
            loadCBRoomNo2();
        }
        string urlApi = "http://localhost:3000/bookings";
        public async Task<string> getDataBooking()
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

        public async Task<string> getDataRoom()
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
                        MessageBox.Show($"Failed to retrieve room data. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public async Task<string> addData(RoomBooking room)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonUser = JsonConvert.SerializeObject(room);
                    StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(urlApi, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        return res;
                    }
                    else
                    {
                        MessageBox.Show($"Add data failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private async Task<string> GenerateReservationNumber()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(urlApi); // You should replace this with an API call to fetch existing reservation numbers.

                if (response.IsSuccessStatusCode)
                {
                    string existingReservationsJson = await response.Content.ReadAsStringAsync();
                    List<RoomBooking> existingReservations = JsonConvert.DeserializeObject<List<RoomBooking>>(existingReservationsJson);

                    int maxIdentifier = 0;
                    foreach (var reservation in existingReservations)
                    {
                        if (reservation.reservationNumber.StartsWith("R") && int.TryParse(reservation.reservationNumber.Substring(1), out int identifier))
                        {
                            if (identifier > maxIdentifier)
                            {
                                maxIdentifier = identifier;
                            }
                        }
                    }

                    int nextIdentifier = maxIdentifier + 1;
                    return "R" + nextIdentifier.ToString("D3"); 
                    // Format as R001, R002, etc.
                }
                else
                {
                    MessageBox.Show("Failed to fetch existing reservations. Status code: " + response.StatusCode);
                }
            }

            return null;
        }
        private async Task<string> updateData(RoomBooking room)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonUser = JsonConvert.SerializeObject(room);
                    StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                    string apiUrl = $"{urlApi}/{room.phoneNumber}";

                    // Assuming you have the user's _id available (replace "userId" with the actual property name)
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the success case here (e.g., display a success message)
                        MessageBox.Show("RoomBooking updated successfully!");

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
            return null;
        }
        private async Task<string> deleteData(string phone)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Construct the URL with the phone number as a query parameter
                    string apiUrl = $"{urlApi}/{phone}";

                    // Send a DELETE request to the constructed URL
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the success case here (e.g., display a success message)
                        MessageBox.Show("RoomBooking deleted successfully!");
                        loadDGV();
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("PhoneNumbers not found.");
                    }
                    else
                    {
                        MessageBox.Show($"Delete failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // ... (existing code)
            string PhoneNumber = txtPhoneNumber.Text;
            int numbers;
            if (PhoneNumber == "")
            {
                MessageBox.Show("Phone invalid");
                return;
            }
            else if (!int.TryParse(PhoneNumber, out numbers))
            {
                MessageBox.Show("Only enter numbers");
                return;
            }
            if (dtpIn.Value > dtpOut.Value)
            {
                MessageBox.Show("The value of the check-in date must be smaller than the check-out date");
                return;
            }
            if (dtpIn.Value < System.DateTime.Now.Date)
            {
                MessageBox.Show("The value of the check-in date must be greater or equal than the current date");
                return;
            }
            try
            {
                string reservationNumber = await GenerateReservationNumber();

                if (reservationNumber != null)
                {
                    RoomBooking room = new RoomBooking
                    {
                        reservationNumber = reservationNumber,
                        startDate = System.DateTime.Now,
                        checkin = dtpIn.Value,
                        checkout = dtpOut.Value,
                        roomNumber = int.Parse(cbxNo.SelectedItem.ToString()),
                        phoneNumber = txtPhoneNumber.Text,
                        style = cbxType.SelectedIndex
                    };

                    string res = await addData(room);
                    RoomBooking roomBookings = JsonConvert.DeserializeObject<RoomBooking>(res);

                    if (res != null)
                    {
                        MessageBox.Show("Add RoomBooking succeeded!");
                        loadDGV();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async Task<List<RoomBooking>> FindBookingWithPhone(string phone)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Construct the URL with the phone number as a query parameter
                    string apiUrl = $"{urlApi}/{phone}";

                    // Send a DELETE request to the constructed URL
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {

                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<RoomBooking> roomList = JsonConvert.DeserializeObject<List<RoomBooking>>(jsonResponse);
                        dgvReservation.Rows.Clear();

                        foreach (var item in roomList)
                        {
                            int index = dgvReservation.Rows.Add();
                            dgvReservation.Rows[index].Cells[0].Value = item.reservationNumber;
                            dgvReservation.Rows[index].Cells[1].Value = item.roomNumber;
                            dgvReservation.Rows[index].Cells[2].Value = item.phoneNumber;
                            dgvReservation.Rows[index].Cells[3].Value = item.checkin;
                            dgvReservation.Rows[index].Cells[4].Value = item.checkout;
                        }
                        return roomList;

                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("PhoneNumbers not found.");
                    }
                    else
                    {
                        MessageBox.Show($"Delete failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string PhoneNumber = txtPhoneNumber2.Text;
            int numbers;
            if (txtPhoneNumber2.Text == "")
            {
                MessageBox.Show("Phone invalid");
                return;
            }
            else if (!int.TryParse(PhoneNumber, out numbers))
            {
                MessageBox.Show("Only enter numbers");
                return;
            }
            if (dtpIn2.Value > dtpOut2.Value)
            {
                MessageBox.Show("The value of the room date must be smaller than the room date");
                return;
            }
            if (dtpIn2.Value < DateTime.Now)
            {
                MessageBox.Show("The value of the room date must be greater than current");
                return;
            }
            try
            {
                RoomBooking room = new RoomBooking
                {
                    reservationNumber = await GenerateReservationNumber(),
                    startDate = System.DateTime.Now,
                    checkin = dtpIn2.Value,
                    checkout = dtpOut2.Value,
                    roomNumber = int.Parse(cbxNo2.SelectedItem.ToString()),
                    phoneNumber = txtPhoneNumber2.Text,
                    style = cbxType2.SelectedIndex
                };
                string res = await updateData(room);
                if (res != null)
                {
                    MessageBox.Show("Update RoomBooking successed!");
                    loadDGV();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = txtPhoneNumber2.Text;
                //int roomNumber = int.Parse(cbxNo2.SelectedItem.ToString());
                string res = await deleteData(phone);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        private async void btnFind_Click_1(object sender, EventArgs e)
        {
            string PhoneNumber = txtSearchPhoneNumber.Text;
            int numbers;
            if (txtSearchPhoneNumber.Text == "")
            {
                MessageBox.Show("Phone invalid");
                return;
            }
            else if (!int.TryParse(PhoneNumber, out numbers))
            {
                MessageBox.Show("Only enter numbers");
            }
            List<RoomBooking> res = await FindBookingWithPhone(PhoneNumber);
        }
        private async void tabPageSearchReservation_Click(object sender, EventArgs e)
        {
            List<RoomBooking> lRoomBooking = JsonConvert.DeserializeObject<List<RoomBooking>>(await getDataBooking());
            if (lRoomBooking != null)
            {
                dgvReservation.Rows.Clear();
                foreach (var item in lRoomBooking)
                {
                    int index = dgvReservation.Rows.Add();
                    dgvReservation.Rows[index].Cells[0].Value = item.reservationNumber;
                    dgvReservation.Rows[index].Cells[1].Value = item.roomNumber;
                    dgvReservation.Rows[index].Cells[2].Value = item.phoneNumber;
                    dgvReservation.Rows[index].Cells[3].Value = item.checkin;
                    dgvReservation.Rows[index].Cells[4].Value = item.checkout;
                }
            }
        }
        private async void tabControlReservation_Click(object sender, EventArgs e)
        {
            List<RoomBooking> lRoomBooking = JsonConvert.DeserializeObject<List<RoomBooking>>(await getDataBooking());
            if (lRoomBooking != null)
            {
                dgvReservation.Rows.Clear();
                foreach (var item in lRoomBooking)
                {
                    int index = dgvReservation.Rows.Add();
                    dgvReservation.Rows[index].Cells[0].Value = item.reservationNumber;
                    dgvReservation.Rows[index].Cells[1].Value = item.roomNumber;
                    dgvReservation.Rows[index].Cells[2].Value = item.phoneNumber;
                    dgvReservation.Rows[index].Cells[3].Value = item.checkin;
                    dgvReservation.Rows[index].Cells[4].Value = item.checkout;
                }
            }
        }

        private async void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Room> lRoom = JsonConvert.DeserializeObject<List<Room>>(await getDataRoom());
            lRoom = lRoom.OrderBy(item => item.roomNumber).ToList();
            cbxNo.Items.Clear();
            foreach (var item in lRoom)
            {
                if (item.style == cbxType.SelectedIndex)
                {
                    cbxNo.Items.Add(item.roomNumber);
                }
            }
        }

        private void txtSearchPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPhoneNumber.Text == "")
            {
                loadDGV();
            }
        }
        private List<RoomBooking> roomNo;

        private async void txtPhoneNumber2_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber2.Text;
         
            if (int.TryParse(phoneNumber, out int roomNumber))
            {
                roomNo = await FindBookingWithPhone(phoneNumber);
                cbxReservationNumber.Items.Clear();
                foreach (var booking in roomNo)
                {
                    cbxReservationNumber.Items.Add(booking.reservationNumber.ToString());
                }
            }
            
        }

        private async void cbxType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Room> lRoom = JsonConvert.DeserializeObject<List<Room>>(await getDataRoom());
            cbxNo2.Items.Clear();
            foreach (var item in lRoom)
            {
                if (item.style == cbxType2.SelectedIndex)
                {
                    cbxNo2.Items.Add(item.roomNumber);
                }

            }
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

        private void cbxReservationNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in roomNo)
            {
                if(item.reservationNumber == cbxReservationNumber.Text)
                {
                    cbxType2.Text = roomStyle(item.style);
                    cbxNo2.Items.Clear();
                    cbxNo2.Items.Add(item.roomNumber);
                    dtpIn2.Value = item.checkin;
                    dtpOut2.Value = item.checkout;
                }
            }

            //cbxNo2.Items.Add(int.Parse(selectedRoomNumberText)); 
        }
    }
}
