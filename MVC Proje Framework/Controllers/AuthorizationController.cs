using BusinessLayer.Concrete;
using DateAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Framework.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager adminmanager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminmanager.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminmanager.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalues = adminmanager.GetByID(id);
            return View(adminvalues);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminmanager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}