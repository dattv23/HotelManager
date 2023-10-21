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
        private async Task<List<BillTransaction>> getData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/billtransactions");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<BillTransaction> billTransactionList = JsonConvert.DeserializeObject<List<BillTransaction>>(jsonResponse);
                        return billTransactionList;
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

        private async void btnStatistic_Click(object sender, EventArgs e)
        {
            chartStatistics.Titles.Clear();
            if (dtpIn.Value > dtpOut.Value)
            {
                MessageBox.Show("The value of the room date must be smaller than the room date");
                return;
            }

            DateTime startDate = dtpIn.Value;
            DateTime endDate = dtpOut.Value;
            List<BillTransaction> list = await getData();
            Dictionary<DateTime, double> roomPrices = new Dictionary<DateTime, double>();
            double sum = 0;

            foreach (BillTransaction transaction in list)
            {
                if (transaction.creationDate >= startDate && transaction.creationDate <= endDate)
                {
                    if (roomPrices.ContainsKey(transaction.creationDate))
                    {
                        roomPrices[transaction.creationDate] += transaction.amount;
                    }
                    else
                    {
                        roomPrices[transaction.creationDate] = transaction.amount;
                    }
                    sum += transaction.amount;
                }
            }
            lblAmount.Text = sum.ToString();
            // Clear existing data in the chart
            chartStatistics.Series["RoomPrices"].Points.Clear();

            // Sort the dictionary by date
            var sortedRoomPrices = roomPrices.OrderBy(entry => entry.Key);

            // Add data to the chart
            foreach (var entry in sortedRoomPrices)
            {
                chartStatistics.Series["RoomPrices"].Points.AddXY(entry.Key.ToString("dd-MM"), entry.Value);
            }
            chartStatistics.ChartAreas[0].AxisX.Interval = 1;
            chartStatistics.Titles.Add("Total Room Rental Prices by Day");
            chartStatistics.ChartAreas[0].AxisX.Title = "Date";
            chartStatistics.ChartAreas[0].AxisY.Title = "Price";
            chartStatistics.Series["RoomPrices"].IsValueShownAsLabel = true;
        }

        private async void ckbStatisticsForMonth_CheckedChanged(object sender, EventArgs e)
        {
            chartStatistics.Titles.Clear();
            lblAmount.Text = "";
            if (ckbStatisticsForMonth.Checked)
            {
                List<BillTransaction> list = await getData();
                Dictionary<DateTime, double> roomPrices = new Dictionary<DateTime, double>();
                double sum = 0;
                chartStatistics.Series["RoomPrices"].Points.Clear();
                foreach (BillTransaction transaction in list)
                {
                    if (transaction.creationDate.Month == DateTime.Now.Month)
                    {
                        // If the transaction date is within the selected date range, add it to the dictionary
                        if (roomPrices.ContainsKey(transaction.creationDate))
                        {
                            // If there's already an entry for this date, add the transaction amount to the existing amount
                            roomPrices[transaction.creationDate] += transaction.amount;
                        }
                        else
                        {
                            // If there's no entry for this date, create a new entry with the transaction amount
                            roomPrices[transaction.creationDate] = transaction.amount;
                        }
                        sum += transaction.amount;
                    }
                }
                // Filter data within the selected date range
                var sortedRoomPrices = roomPrices.OrderBy(entry => entry.Key);
                lblAmount.Text = sum.ToString();
                chartStatistics.Series["RoomPrices"].Points.Clear(); // Clear existing data
                foreach (var entry in roomPrices)
                {
                    chartStatistics.Series["RoomPrices"].Points.AddXY(entry.Key.ToString("dd-MM"), entry.Value);
                }
                chartStatistics.ChartAreas[0].AxisX.Interval = 1;
                chartStatistics.Titles.Add("Total Room Rental Prices by Day");
                chartStatistics.ChartAreas[0].AxisX.Title = "Date";
                chartStatistics.ChartAreas[0].AxisY.Title = "Price";
                chartStatistics.Series["RoomPrices"].IsValueShownAsLabel = true;
            }
            else
            {
                chartStatistics.Series["RoomPrices"].Points.Clear();
                return;
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
