using System;
using SOP.Domain;
using SOP.Domain.IRepositories;
using SOP.Domain.Models;

namespace SOP.Business.Services
{
    public class AddressService:IAddressService
    {
        private readonly IRepository<Address> _iAdRepository;

        public AddressService(IRepository<Address> iAdRepository)
        {
            if (iAdRepository == null)
                throw new ArgumentNullException("iAdRepository");

            _iAdRepository = iAdRepository;
        }

        public void AddAddress(Address address)
        {
            if (Convert.ToInt32(address.Numero) > 1)
            {
                address.Calle = "Calle mayor a 1";
                _iAdRepository.Add(address);
            }
            else
            {
                address.Calle = "Calle menor a 1";
                _iAdRepository.Add(address);
            }

        }
    }
}