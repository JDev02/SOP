using System.Web.Mvc;
using NUnit.Framework;
using SOP.Business.Services;
using SOP.Data.Repositories;
using SOP.UI.Web.Controllers;

namespace SOP.UI.Test.Web
{
    [TestFixture]
    public class HomeTest
    {
        [Test]
        public void SiHomeDaComoRespuestaUnViewBag()
        {
            // Arrange
            var addressRep = new sqlAddressRepository(@"C:\hola.txt");
            var adreesService = new AddressService(addressRep);
            HomeController controller = new HomeController(adreesService);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            ViewDataDictionary viewData = result.ViewData;
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", viewData["Message"]);
        }
    }
}