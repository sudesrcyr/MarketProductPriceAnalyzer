using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketList
{
    public class Market
    {
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }

        public Market(string productName, string unit, decimal price)
        {
            ProductName = productName;
            Unit = unit;
            Price = price;
        }
    }
}