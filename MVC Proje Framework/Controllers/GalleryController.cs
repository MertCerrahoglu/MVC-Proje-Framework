using BusinessLayer.Concrete;
using DateAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Framework.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery

        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
        
    }
}