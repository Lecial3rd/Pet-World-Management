using PetWorldManagement.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Repository.Facade
{
    public class SupplierProductFacade
    {
        private readonly ProductSupplierRepository repository;
        public SupplierProductFacade() 
        {
            repository = new ProductSupplierRepository();
        }
        public void insertProductSuppliers(List<SupplierProductObject> supplierProducts)
        {
            repository.insertProductSuppliers(supplierProducts);
        }
    }
}
