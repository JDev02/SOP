using System;
using System.IO;
using SOP.Domain.IRepositories;
using SOP.Domain.Models;

namespace SOP.Data.Repositories
{
    public class CustomerRepository:IRepository<Customer>
    {
        private readonly string _path;

        public CustomerRepository(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");

            _path = path;
        }

        public void Add(Customer customer)
        {
            using (var outfile = new StreamWriter(_path))
            {
                outfile.WriteLine(customer.Name);
                outfile.WriteLine(customer.LasName);
                outfile.WriteLine(customer.Phone);
                outfile.WriteLine(customer.Email);
                outfile.WriteLine(customer.Addrres);
            }
        }
    }
}