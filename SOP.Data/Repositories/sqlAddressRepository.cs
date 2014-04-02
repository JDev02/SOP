using System;
using System.IO;
using SOP.Domain;
using SOP.Domain.IRepositories;
using SOP.Domain.Models;

namespace SOP.Data.Repositories
{
    public class sqlAddressRepository:IRepository<Address>
    {
         private readonly string _connectionString;

        public sqlAddressRepository(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException("connectionString");

            _connectionString = connectionString;
        }

        public void Add(Address address)
        {
            using (var outfile = new StreamWriter(_connectionString))
            {
                outfile.WriteLine("hola soy un sql");
                outfile.WriteLine(address.Calle);
                outfile.WriteLine(address.Numero);
            }
        }
    }
}