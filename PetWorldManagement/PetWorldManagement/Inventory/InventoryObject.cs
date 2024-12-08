using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Inventory
{
    public class InventoryObject
    {
        public int ID { get; set; } // Inventory ID
        public int SupplierID { get; set; } // Supplier ID
        public int ProductID { get; set; } // Product ID
        public string Product { get; set; } // Product name
        public int QtyReceived { get; set; } // Quantity
        public string DateDelivery { get; set; } // Delivery date
        public string DateReceived { get; set; } // Received date
        public string DateExpiration { get; set; } // Expiration date
        public int StockID { get; set; } // Stock ID
        public int StatusID { get; set; } // Status ID
        public decimal Price { get; set; } // Price
        public string ProductName { get; set; }
        public decimal TotalPrice { get; set; } // Total Price
        public string Supplier { get; set; } // Supplier name
    }
}
