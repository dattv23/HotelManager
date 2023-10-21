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
    public partial class UserControlStatistic : UserControl
    {
        public UserControlStatistic()
        {
            InitializeComponent();
        }
        private string roomUrl = "http://127.0.0.1:3000/rooms";
        private string bookingsUrl = "http://127.0.0.1:3000/bookings";
        private async Task LoadAllRoomsAsync(DateTime checkin, DateTime checkout)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var roomResponse = await client.GetAsync(roomUrl);
                    var bookingsResponse = await client.GetAsync(bookingsUrl);

                    if (roomResponse.IsSuccessStatusCode && bookingsResponse.IsSuccessStatusCode)
                    {
                        string jsonRoomResponse = await roomResponse.Content.ReadAsStringAsync();
                        string jsonBookingResponse = await bookingsResponse.Content.ReadAsStringAsync();

                        List<Room> roomList = JsonConvert.DeserializeObject<List<Room>>(jsonRoomResponse);
                        List<RoomBooking> bookingList = JsonConvert.DeserializeObject<List<RoomBooking>>(jsonBookingResponse);

                        // Clear existing rows in the DataGridView
                        dgvStatistic.Rows.Clear();

                        double sumAmount = 0;

                        // Add new room data to DataGridView
                        foreach (var booking in bookingList)
                        {
                            if (booking.checkin > checkin && booking.checkin < checkout)
                            {
                                var matchingRoom = roomList.FirstOrDefault(room => room.roomNumber == booking.roomNumber);
                                if (matchingRoom != null)
                                {
                                    int index = dgvStatistic.Rows.Add();
                                    dgvStatistic.Rows[index].Cells[0].Value = booking.roomNumber;
                                    string styleString = "";
                                    switch (booking.style)
                                    {
                                        case 0:
                                            styleString = "Standard";
                                            break;
                                        case 1:
                                            styleString = "Deluxe";
                                            break;
                                        case 2:
                                            styleString = "Family";
                                            break;
                                        case 3:
                                            styleString = "Business";
                                            break;
                                        default:
                                            styleString = "Unknown";
                                            break;
                                    }
                                    dgvStatistic.Rows[index].Cells[1].Value = styleString;
                                    dgvStatistic.Rows[index].Cells[2].Value = matchingRoom.bookingPrice;
                                    dgvStatistic.Rows[index].Cells[3].Value = booking.startDate.ToString("dd/MM/yyyy");
                                    dgvStatistic.Rows[index].Cells[5].Value = booking.phoneNumber;

                                    var isSmokingCell = new DataGridViewCheckBoxCell();
                                    isSmokingCell.Value = matchingRoom.isSmoking;
                                    dgvStatistic.Rows[index].Cells[4] = isSmokingCell;
                                    sumAmount += matchingRoom.bookingPrice;
                                }
                                else
                                {
                                    MessageBox.Show("Not found");
                                }
                            }
                        }

                        lblAmount.Text = sumAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Error loading data. Status Code: {roomResponse.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private async Task LoadAllRoomsAsync(int month)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var roomResponse = await client.GetAsync(roomUrl);
                    var bookingsResponse = await client.GetAsync(bookingsUrl);

                    if (roomResponse.IsSuccessStatusCode && bookingsResponse.IsSuccessStatusCode)
                    {
                        string jsonRoomResponse = await roomResponse.Content.ReadAsStringAsync();
                        string jsonBookingResponse = await bookingsResponse.Content.ReadAsStringAsync();

                        List<Room> roomList = JsonConvert.DeserializeObject<List<Room>>(jsonRoomResponse);
                        List<RoomBooking> bookingList = JsonConvert.DeserializeObject<List<RoomBooking>>(jsonBookingResponse);

                        // Clear existing rows in the DataGridView
                        dgvStatistic.Rows.Clear();

                        double sumAmount = 0;

                        // Add new room data to DataGridView
                        foreach (var booking in bookingList)
                        {
                            if (booking.checkin.Month == month)
                            {
                                var matchingRoom = roomList.FirstOrDefault(room => room.roomNumber == booking.roomNumber);
                                if (matchingRoom != null)
                                {
                                    int index = dgvStatistic.Rows.Add();
                                    dgvStatistic.Rows[index].Cells[0].Value = booking.roomNumber;
                                    string styleString = "";
                                    switch (booking.style)
                                    {
                                        case 0:
                                            styleString = "Standard";
                                            break;
                                        case 1:
                                            styleString = "Deluxe";
                                            break;
                                        case 2:
                                            styleString = "Family";
                                            break;
                                        case 3:
                                            styleString = "Business";
                                            break;
                                        default:
                                            styleString = "Unknown";
                                            break;
                                    }
                                    dgvStatistic.Rows[index].Cells[1].Value = styleString;
                                    dgvStatistic.Rows[index].Cells[2].Value = matchingRoom.bookingPrice;
                                    dgvStatistic.Rows[index].Cells[3].Value = booking.startDate.ToString("dd/MM/yyyy");
                                    dgvStatistic.Rows[index].Cells[5].Value = booking.phoneNumber;

                                    var isSmokingCell = new DataGridViewCheckBoxCell();
                                    isSmokingCell.Value = matchingRoom.isSmoking;
                                    dgvStatistic.Rows[index].Cells[4] = isSmokingCell;
                                    sumAmount += matchingRoom.bookingPrice;
                                }
                                else
                                {
                                    MessageBox.Show("Not found");
                                }
                            }
                        }

                        lblAmount.Text = sumAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Error loading data. Status Code: {roomResponse.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if(dtpIn.Value <= dtpOut.Value)
            {
                await LoadAllRoomsAsync(dtpIn.Value, dtpOut.Value);
            }
            else
            {
                MessageBox.Show("The value of the room date must be smaller than the room date");
                return;
            }
        }

        private async void ckbStatisticsForMonth_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbStatisticsForMonth.Checked == true)
                await LoadAllRoomsAsync(DateTime.Now.Month);
            else dgvStatistic.Rows.Clear();
        }
    }
}
