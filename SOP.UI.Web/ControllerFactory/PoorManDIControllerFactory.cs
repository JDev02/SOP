using System;
using System.Web.Mvc;
using SOP.Business.Services;
using SOP.Data.Repositories;
using SOP.UI.Web.Controllers;

namespace SOP.UI.Web.ControllerFactory
{
    public class PoorManDIControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            //var customerRepository = new CustomerRepository(@"C:\hola.txt");
            //var customerService = new CustomerService(customerRepository);

            //return controllerType == typeof(HomeController) ?
            //new HomeController(customerService) : base.GetControllerInstance(requestContext, controllerType);
            var txtaddressRespository = new AddressRepository(@"C:\hola.txt");
            var sqladdressRespository = new sqlAddressRepository(@"C:\hola.txt");
            var addressService = new AddressService(sqladdressRespository);
            return controllerType == typeof(HomeController) ?
            new HomeController(addressService) : base.GetControllerInstance(requestContext, controllerType);

        } 
    }
}