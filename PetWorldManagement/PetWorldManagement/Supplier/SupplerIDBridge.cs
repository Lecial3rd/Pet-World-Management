using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Supplier
{
    public static class SupplerIDBridge
    {
        public static int SupplierID;
        public static void setSupplierID(int ValueSupplierID)
        {
            SupplierID = ValueSupplierID;
        }

        public static int getSupplierID()
        {
            return SupplierID;
        }
    }
}
