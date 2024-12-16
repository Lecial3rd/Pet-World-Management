
using PetWorldManagement.Appointments;
using PetWorldManagement.Inventory;
using PetWorldManagement.Repository;
using PetWorldManagement.Repository.RepositoryFactoryMethod;
using PetWorldManagement.Service;
using PetWorldManagement.Stock;
using PetWorldManagement.Supplier;
using PetWorldManagement.Supplier.PurchaseOrder;
using System;
namespace PetWorldManagement
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<T> CreateRepository<T>() where T : class
        {
            if (typeof(T) == typeof(ProductObject))
            {
                return new ProductRepository() as IRepository<T>;
            }
            else if (typeof(T) == typeof(CategoryObject))
            {
                return new CategoryRepository() as IRepository<T>;
            }else if(typeof(T) == typeof(SupplierObject))
            {
                return new SupplierRepository() as IRepository<T>;
            }else if(typeof(T) == typeof(OrderObject))
            {
                return new OrderFormRepository() as IRepository<T>;
            }else if(typeof(T) == typeof(StockObject))
            {
                return new StockRepository() as IRepository<T>;
            }else if(typeof (T) == typeof(InventoryObject)) { 
                return new InventoryRepository() as IRepository<T>;
            }else if( typeof(T) == typeof(SupplierProductObject))
            {  
                return new ProductSupplierRepository() as IRepository<T>;
            }
            else if (typeof(T) == typeof(AppointmentObject))
            {
                return new InvoiceRepository() as IRepository<T>;
            }else if(typeof(T) == typeof(ServiceObject))
            {
                return new ServiceRepository() as IRepository<T>;
            }else if(typeof(T) == typeof(StaffObject))
            {
                return new StaffRepository() as IRepository<T>;
            }

            throw new NotImplementedException($"Repository for type {typeof(T).Name} not implemented.");
        }
    }
}
