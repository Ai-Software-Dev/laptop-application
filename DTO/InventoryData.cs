using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryData
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public int StockLevel { get; set; }
        public double Price { get; set; }
        public bool NeedRestock { get; set; }

        public InventoryData(int productId, string productName, int quantitySold, int stockLevel, double price, bool needRestock)
        {
            ProductId = productId;
            ProductName = productName;
            QuantitySold = quantitySold;
            StockLevel = stockLevel;
            Price = price;
            NeedRestock = needRestock;
        }
    }
}
