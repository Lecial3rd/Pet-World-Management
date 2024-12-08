using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Supplier.PurchaseOrder
{
    public class OrderObject
    {
        public int supplierID {  get; set; }
        public string supplierName { get; set; }
        public string productName {  get; set; }
        public int productId { get; set; }
        public int numberOfItem { get; set; }
        public string status { get; set; }
        public string deliveryDate { get; set; }
        public string expirationDate { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
