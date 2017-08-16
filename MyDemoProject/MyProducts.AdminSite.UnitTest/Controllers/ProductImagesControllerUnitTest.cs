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
    public class ProductImagesControllerUnitTest
    {
        [TestMethod]
        public void index()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);  
        }
        [TestMethod]
        public void create()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void edit()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Edit(3) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void delete()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Delete(3) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void details()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Details(1) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
