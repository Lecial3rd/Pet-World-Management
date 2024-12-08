using PetWorldManagement.Repository.Facade;
using PetWorldManagement.Supplier;
using PetWorldManagement.Supplier.PurchaseOrder;
using System.Collections.Generic;
using System.Data;

namespace PetWorldManagement
{
    public class RepositoryFacade<T> where T : class
    {
        private readonly IRepository<T> repository;
        private readonly OrderRepositoryFacade orderFacade;
        private readonly SupplierProductFacade supplierProductFacade;

        public RepositoryFacade(IRepositoryFactory factory)
        {
            repository = factory.CreateRepository<T>();
            orderFacade = new OrderRepositoryFacade();
            supplierProductFacade = new SupplierProductFacade();
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        public DataTable Search(string keyword)
        {
            return repository.Search(keyword);
        }

        public void Add(T entity)
        {
            repository.Add(entity);
        }

        public void Update(T entity)
        {
            repository.Update(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }


        // Specialized methods for OrderFacade
        public List<ProductItem> GetSupplierProducts(int supplierID)
        {
            return orderFacade.GetSupplierProducts(supplierID);
        }

        public (int StatusID, string Status) GetStatus()
        {
            return orderFacade.GetStatus();
        }

        public string GetSupplierName(int supplierID)
        {
            return orderFacade.GetSupplierName(supplierID);
        }

        public int GetProductCategoryID(int productID)
        {
            return orderFacade.GetCategoryID(productID);
        }

        public DataTable GetStatuses()
        {
            return orderFacade.GetStatuses();
        }

        public DataTable GetInventoryProduct()
        {
            return orderFacade.GetInventoryProduct();
        }


        //Specialized Method for supplierProductFacade
        public void insertProductSuppliers(List<SupplierProductObject> supplierProducts)
        {
            supplierProductFacade.insertProductSuppliers(supplierProducts);
        }
    }
}

