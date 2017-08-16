using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Description;
using MyProducts.AdminSite.Models;
using System.Web.Http.Cors;

namespace Myproduct.MyWebApi.Controllers
{
    [EnableCors(origins: "http://localhost:63618", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private PetWaresEntities db = new PetWaresEntities();

        // GET: api/ApiProducts
        public IEnumerable<Product> GetProducts()
        {
            var products = db.Products.AsEnumerable();
            return products.ToList();
        }
    }
}