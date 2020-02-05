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
        myLocalDBLYKEntities db = new myLocalDBLYKEntities();

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

        public ActionResult ShowUser()
        {
            var item = db.Users.ToList();
            return View(item);
        }

        public ActionResult DeleteUser(int id)
        {
            var item = db.Users.Where(x => x.ID == id).First();
            db.Users.Remove(item);
            db.SaveChanges();
            var item2 = db.Users.ToList();
            return View("ShowUser", item2);
        }

        public ActionResult EditUser(int id)
        {
            var item = db.Users.Where( x => x.ID == id).First();
            return View(item);

        }
        [HttpPost]
        public ActionResult EditUser(User model)
        {
            var item = db.Users.Where(x => x.ID == model.ID).First();
            item.name = model.name;
            item.email = model.email;
            item.phone = model.phone;
            item.address = model.address;
            item.neighborhood = model.neighborhood;
            item.city = model.city;
            item.state = model.state;
            db.SaveChanges();
            return RedirectToAction("ShowUser");

        }
    }
}