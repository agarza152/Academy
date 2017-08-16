using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MyProducts.AdminSite.Controllers;
using MyProducts.AdminSite.Models;

namespace MyProducts.AdminSite.UnitTest.Controllers
{
    [TestClass]
   public class HomeUnitTest
    {
        [TestMethod]
        public void index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void contact()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Contact() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void about()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
