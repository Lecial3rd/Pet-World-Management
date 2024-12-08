using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Stock
{
    public class StockObject
    {
        public int StockID { get; set; }   
        public int ProductID { get; set; }
        public int Qty { get; set; }
        public int QtyDamage { get; set; }
        public string Date {  get; set; }
        public string Type { get; set; }

        public int numberOfItem { get; set; }
    }
}
