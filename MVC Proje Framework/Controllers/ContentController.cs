using BusinessLayer.Concrete;
using DateAccessLayer.Concrete;
using DateAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Framework.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        Context c = new Context();
        public ActionResult GetAllContent(string p)
        {
            var  values =cm.GetList(p);
            //var values = c.Contents.ToList();
            return View(values);
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetlistByHeadingID(id);
            return View(contentvalues);
        }
    }
}