using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement
{
    public class ProductObject
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductImage { get; set; } // Image as byte array
    }

}
