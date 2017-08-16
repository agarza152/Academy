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
    public class ProductUnitTest
    {
        [TestMethod]
        public void index()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void details()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Details(2) as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void edit()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Edit(1) as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void delete()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Delete(2) as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void create()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Create() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void create2()
        {
            ProductsController controller = new ProductsController();
            Product product = new Product();
            product.Name = "hola";
            product.CategoryId = 3;
            ViewResult result = controller.Create(product) as ViewResult;
            Assert.IsTrue(product.id > 0);
        }
        

    }
}
