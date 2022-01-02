using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DatabaseAdapter;
using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        List<NissanProduct> products = new List<NissanProduct>();
       private IDatabase _db;

        // GET: Product

        public ProductController(IDatabase database) 
        {
            if (database != null)
                _db = database;
            else
                throw new ArgumentNullException();
        }
        public string Index()
        {
            return "This is my eccomerece Website";
        }

        public string GetAllList()
        {
            return products.Count.ToString();
        }
        /*Heap produc11
         * 
         * products =>1 produc1
         * t*/
        public bool AddProduct() {
            
          return  _db.AddRecord();

        }        
    }
}