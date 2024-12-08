using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Supplier.PurchaseOrder
{
    public class ProductItem
    {
        public int ProductID { get; }
        public string ProductName { get; }

        public decimal ItemPrice { get; }

        public ProductItem(int id, string name, decimal itemPrice)
        {
            ProductID = id;
            ProductName = name;
            ItemPrice=itemPrice;
        }
    }
}
