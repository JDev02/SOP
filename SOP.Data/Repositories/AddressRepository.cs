using System;
using System.IO;
using SOP.Domain.IRepositories;
using SOP.Domain.Models;

namespace SOP.Data.Repositories
{
    public class AddressRepository:IRepository<Address>
    {
        private readonly string _path;

        public AddressRepository(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");

            _path = path;
        }

        public void Add(Address address)
        {
            using (var outfile = new StreamWriter(_path))
            {
                outfile.WriteLine("hola soy un txt");
                outfile.WriteLine(address.Calle);
                outfile.WriteLine(address.Numero);
            }
        }
    }
}