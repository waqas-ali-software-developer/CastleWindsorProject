using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DatabaseAdapter;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private IDatabase _db;
        public AccountController(IDatabase database) {
            _db = database;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public bool AddAccount()
        {
            return _db.AddRecord();

        }
    }
}