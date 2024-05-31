using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketList
{
    public class MarketSummary
    {
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal AveragePrice { get; set; }

        public MarketSummary(string productName, string unit, decimal minPrice, decimal maxPrice, decimal averagePrice)
        {
            ProductName = productName;
            Unit = unit;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            AveragePrice = averagePrice;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
