using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOP.Business.Services;

namespace SOP.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAddressService _addressService;

        public HomeController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
