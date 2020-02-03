using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webAppCognizantTest.Models;

namespace webAppCognizantTest.Controllers
{
    public class UserController : Controller
    {
        Model1 db = new Model1();
        // GET: User
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User model)
        {
            User tbl = new User();
            tbl.name = model.name;
            tbl.email = model.email;
            tbl.phone = model.phone;
            tbl.address = model.address;
            tbl.neighborhood = model.neighborhood;
            tbl.city = model.city;
            tbl.state = model.state;
            db.Users.Add(tbl);
            db.SaveChanges();
            return View();
        }
    }
}