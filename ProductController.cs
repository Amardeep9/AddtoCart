using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        ProductModel pro = new ProductModel();
        DataAccessLayer objproduct = new DataAccessLayer();
       [HttpGet]
        public ActionResult AddtoCart()
        {
            return View(pro);
        }
        [HttpPost]
        public ActionResult AddtoCart(int? id)
        {
            return View();
        }




      







        public ActionResult GetAllProducts()
        {
            List<ProductModel> lstProducts = new List<ProductModel>();
            lstProducts = objproduct.GetAllProducts().ToList();

            return View();
        }
        
    }
}