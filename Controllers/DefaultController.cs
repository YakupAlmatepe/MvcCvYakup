using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvYakup.Models;
using MvcCvYakup.Models.Entity;

namespace MvcCvYakup.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvYakupEntities db = new DbCvYakupEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
           
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler=db.TblDeneyimler.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimler()
        {
            var egitimler = db.TblEgitim.ToList();
            return PartialView(egitimler);
        }
    }
}