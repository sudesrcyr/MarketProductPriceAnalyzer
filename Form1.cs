using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MarketList
{
    public partial class Form1 : Form
    {
        private List<Market> marketList = new List<Market>();
        private List<MarketSummary> summaryList = new List<MarketSummary>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadAllData_Click(object sender, EventArgs e)
        {
            marketList.Clear(); // Clear previous data

            // Read data from file and populate marketList
            try
            {
                using (StreamReader sr = new StreamReader("market.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string productName = parts[0];
                            string unit = parts[1];
                            decimal price = decimal.Parse(parts[2]);
                            marketList.Add(new Market(productName, unit, price));
                        }
                    }
                }

                // Display number of elements read
                lblItems.Text = $"Elements Read: {marketList.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            summaryList.Clear(); // Clear previous data

            // Group by product name and calculate min, max, and average price
            var groups = marketList.GroupBy(m => m.ProductName);
            foreach (var group in groups)
            {
                string productName = group.Key;
                string unit = group.First().Unit;
                decimal minPrice = group.Min(m => m.Price);
                decimal maxPrice = group.Max(m => m.Price);
                decimal avgPrice = group.Average(m => m.Price);
                summaryList.Add(new MarketSummary(productName, unit, minPrice, maxPrice, avgPrice));
            }

            // Populate ListBox with product names
            listBox1.DataSource = null;
            listBox1.DataSource = summaryList;
            listBox1.DisplayMember = "ProductName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MarketSummary selectedSummary = (MarketSummary)listBox1.SelectedItem;
                MessageBox.Show($"Product Name: {selectedSummary.ProductName}\n" +
                                $"Unit: {selectedSummary.Unit}\n" +
                                $"Min Price: {selectedSummary.MinPrice}\n" +
                                $"Max Price: {selectedSummary.MaxPrice}\n" +
                                $"Average Price: {selectedSummary.AveragePrice}");
            }
        }
    }


}