using System;
using SOP.Domain;
using SOP.Domain.IRepositories;
using SOP.Domain.Models;

namespace SOP.Business.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly IRepository<Customer> _custRepository;

        public CustomerService(IRepository<Customer> custRepository)
        {
            if (custRepository == null)
                throw new ArgumentNullException("custRepository");

            _custRepository = custRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _custRepository.Add(customer);
        }  
    }
}