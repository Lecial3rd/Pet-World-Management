using System;
using System.Data;
using PetWorldManagement.Invoice;
using PetWorldManagement.Repository.RepositoryFactoryMethod;

namespace PetWorldManagement.Facade
{
    public class InvoiceAppointmentFacade
    {
        private readonly InvoiceRepository invoiceRepository;

        public InvoiceAppointmentFacade()
        {
            invoiceRepository = new InvoiceRepository();
        }

        public DataTable GetAllInvoices()
        {
            try
            {
                return invoiceRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving all invoices.", ex);
            }
        }

        public DataTable ViewSpecificAppointmentInvoice(int invoiceID)
        {
            try
            {
                return invoiceRepository.ViewSpecificAppointmentInvoice(invoiceID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving specific invoice.", ex);
            }
        }

        public DataTable ViewSpecificSalesInvoice(int invoiceID)
        {
            try
            {
                return invoiceRepository.ViewSpecificSalesInvoice(invoiceID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving specific invoice.", ex);
            }
        }

        public DataTable SearchInvoice(string invoiceKeyword)
        {
            try
            {
                return invoiceRepository.Search(invoiceKeyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching for invoice.", ex);
            }
        }
    }
}