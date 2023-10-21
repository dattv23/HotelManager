using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
//using static DevExpress.XtraEditors.Mask.MaskSettings;
using DevExpress.Utils.Svg;
using DevExpress.Utils.ScrollAnnotations;
using DevExpress.Utils;
//using DevExpress.XtraPrinting.Native.Properties;

namespace QuanLyKhachSan
{
    public partial class UserControlRoom : UserControl
    {
        private string baseUrl = "http://127.0.0.1:3000/rooms";

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

        private async Task LoadAllRoomsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(baseUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<Room> roomList = JsonConvert.DeserializeObject<List<Room>>(jsonResponse);

                        // Xóa tất cả các hàng hiện có trong DataGridView
                        dgvRoom.Rows.Clear();

                        // Thêm dữ liệu phòng mới vào DataGridView
                        foreach (var room in roomList)
                        {
                            int index = dgvRoom.Rows.Add();
                            dgvRoom.Rows[index].Cells[0].Value = room.roomNumber;
                            dgvRoom.Rows[index].Cells[1].Value = roomStyle(room.style);
                            dgvRoom.Rows[index].Cells[2].Value = room.bookingPrice;
                            dgvRoom.Rows[index].Cells[3].Value = room.status == 0 ? "Available" : "Not Available";

                            var isSmokingCell = new DataGridViewCheckBoxCell();
                            isSmokingCell.Value = room.isSmoking == true;
                            dgvRoom.Rows[index].Cells[4] = isSmokingCell;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi tải dữ liệu. Mã trạng thái: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        public UserControlRoom()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            cmbType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtBookingPrice.Clear();
            rdbYes.Checked = false;
            rdbNo.Checked = false;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }
        public void Clear2()
        {
            txtRoomNoUp.Clear();
            cmbTypeUp.SelectedIndex = -1;
            cmbStatusUp.SelectedIndex = -1;
            txtBookingPriceUp.Clear();
            rdbYes2.Checked = false;
            rdbNo2.Checked = false;
        }

        private async Task<bool> AddRoomAsync()
        {
            try
            {
                int roomNumber = int.Parse(txtRoomNo.Text);

                // Kiểm tra xem phòng có cùng RoomNo đã tồn tại trong dgvRoom hay chưa
                if (IsRoomExists(roomNumber))
                {
                    MessageBox.Show("A room already exists.", "Error");
                    return false;
                }

                int style = cmbType.SelectedIndex;
                int status = cmbStatus.SelectedIndex;
                string bookingPrice = txtBookingPrice.Text;
                bool isSmoking = rdbYes.Checked;

                if (!Validator.IsValidBookingPrice(bookingPrice))
                {
                    MessageBox.Show("Booking price is not valid.");
                    return false;
                }

                var roomData = new
                {
                    roomNumber,
                    style,
                    status,
                    bookingPrice,
                    isSmoking
                };

                var content = new StringContent(JsonConvert.SerializeObject(roomData), Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.PostAsync(baseUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Room added successfully.");
                        Clear();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Room added unsuccessfully.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }
        private async Task<bool> UpdateRoomAsync(object room)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonRoom = JsonConvert.SerializeObject(room);
                    StringContent content = new StringContent(jsonRoom, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync("http://127.0.0.1:3000/rooms", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Room updated successfully!");
                        Clear2();
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

        private async Task<bool> DeleteRoomAsync(int roomNumber)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://127.0.0.1:3000/rooms/{roomNumber}";
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Room deleted successfully!");
                        return true;
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
            return false;
        }
        public class Validator
        {
            public static bool IsValidBookingPrice(string bookingPrice)
            {
                // Kiểm tra xem giá không rỗng và không chứa ký tự đặc biệt
                return !string.IsNullOrEmpty(bookingPrice) && Regex.IsMatch(bookingPrice, @"^\d+(\.\d+)?$");
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRoomNo.Text) || cmbType.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(txtBookingPrice.Text) || (!rdbYes.Checked && !rdbNo.Checked))
            {
                MessageBox.Show("Please enter all required data before adding a room.", "Error");
                return;
            }

            await AddRoomAsync();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNoUp.Text))
            {
                MessageBox.Show("Please enter room number to update.", "Error");
                return;
            }

            if (!int.TryParse(txtRoomNoUp.Text, out int roomNumber))
            {
                MessageBox.Show("Invalid room number. Please enter a valid room number.", "Error");
                return;
            }

            // Kiểm tra xem phòng có tồn tại trong danh sách phòng hay không
            if (IsRoomExists(roomNumber))
            {
                int style = cmbTypeUp.SelectedIndex;
                int status = cmbStatusUp.SelectedIndex;
                string bookingPrice = txtBookingPriceUp.Text;
                bool isSmoking = rdbYes2.Checked;

                if (!Validator.IsValidBookingPrice(bookingPrice))
                {
                    MessageBox.Show("Booking price is not valid.");
                    return;
                }

                var newRoom = new
                {
                    roomNumber,
                    style,
                    status,
                    bookingPrice,
                    isSmoking
                };

                await UpdateRoomAsync(newRoom);
                await LoadAllRoomsAsync();
                Clear2();
            }
            else
            {
                MessageBox.Show("Room not found.", "Error");
            }
        }
        // Kiểm tra phòng đã tồn tại hay chưa cho hàm Add và Update.
        private bool IsRoomExists(int roomNumber)
        {
            foreach (DataGridViewRow row in dgvRoom.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == roomNumber)
                {
                    return true;
                }
            }
            return false;
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRoomNoUp.Text == "")
            {
                MessageBox.Show("Please fill room number to delete!", "Error");
            }
            else
            {
                int roomNumber = int.Parse(txtRoomNoUp.Text);

                var deleteResult = await DeleteRoomAsync(roomNumber);

                if (deleteResult)
                {
                    await LoadAllRoomsAsync();
                    Clear2();
                }
            }
        }
        private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Enter numbers only", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtBookingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Enter numbers only", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            txtSearchRoomNo.Clear();
        }

        private void txtSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            string searchRoomNo = txtSearchRoomNo.Text.Trim();

            foreach (DataGridViewRow row in dgvRoom.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string roomNumber = row.Cells[0].Value.ToString();
                    bool isMatch = roomNumber.StartsWith(searchRoomNo);
                    row.Visible = isMatch;
                }
            }
        }

        private async void tabControlRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlRoom.SelectedTab == tabPageSearchRoom)
            {
                // Chuyển sang tabPageSearch, nạp toàn bộ dữ liệu phòng
                await LoadAllRoomsAsync();
            }
        }

        private void txtRoomNoUp_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRoomNoUp.Text, out int roomNumber))
            {
                // Tìm thông tin phòng từ dgvRoom
                foreach (DataGridViewRow row in dgvRoom.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == roomNumber)
                    {
                        // Lấy thông tin phòng từ dgvRoom
                        //int style = Convert.ToInt32(row.Cells[1].Value);
                        string bookingPrice = row.Cells[2].Value.ToString();
                        //int status = Convert.ToInt32(row.Cells[3].Value);
                        bool isSmoking = Convert.ToBoolean(row.Cells[4].Value);

                        // Cập nhật các controls trong tabControlUpdateAndDelete
                        cmbTypeUp.SelectedItem = row.Cells[1].Value;
                        txtBookingPriceUp.Text = bookingPrice;
                        cmbStatusUp.SelectedItem = row.Cells[3].Value;
                        rdbYes2.Checked = isSmoking;
                        rdbNo2.Checked = !isSmoking;
                        return;
                    }
                }
                cmbTypeUp.SelectedIndex = -1;
                txtBookingPriceUp.Clear();
                cmbStatusUp.SelectedIndex = -1;
                rdbYes2.Checked = false;
                rdbNo2.Checked = false;
            }
            else
            {
                return;
            }
        }

        private void txtRoomNoUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Enter numbers only", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtBookingPriceUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Enter numbers only", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageUpDateAndDelete_Leave(object sender, EventArgs e)
        {
            Clear2();
        }
    }
}
