using PetWorldManagement.Repository;
using PetWorldManagement.Supplier.PurchaseOrder;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetWorldManagement.Repository.Facade
{
    public class OrderRepositoryFacade
    {
        private readonly OrderFormRepository _orderRepository;

        public OrderRepositoryFacade()
        {
            _orderRepository = new OrderFormRepository();
        }

        public List<ProductItem> GetSupplierProducts(int supplierID)
        {
            return _orderRepository.GetSupplierProducts(supplierID);
        }

        public int GetCategoryID(int productID)
        {
            return _orderRepository.GetCategoryID(productID);
        }

        public (int StatusID, string Status) GetStatus()
        {
            return _orderRepository.GetStatus();
        }

        public string GetSupplierName(int supplierID)
        {
            return _orderRepository.GetSupplierName(supplierID);
        }

        public DataTable GetStatuses()
        {
            return _orderRepository.GetStatuses();
        }

        public DataTable GetInventoryProduct()
        {
            return _orderRepository.GetInventoryProduct();
        }
    }
}
