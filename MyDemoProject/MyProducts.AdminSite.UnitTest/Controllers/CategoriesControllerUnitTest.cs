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
   public class CategoriesControllerUnitTest
    {
        [TestMethod]
        public void index()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}