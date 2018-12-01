using lawyer2015.Models;
using lawyer2015.Models.Scripts;
using lawyer2015.Models.ViewModel;
using lawyer2015.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lawyer2015.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: /User/AddAddress
        public ActionResult AddAddress(bool show)
        {
            ViewBag.Show = show;
            List<SelectListItem> Cities = ApplicationManager.GetDropDown<City>(db.City);
            return PartialView(Cities);
        }

        public ActionResult AddTelephone(bool show)
        {
            ViewBag.Show = show;
            return PartialView();
        }

        public ActionResult AddCert(bool show)
        {
            ViewBag.Show = show;
            return PartialView();
        }

        public ActionResult AddEduQual(bool show)
        {
            ViewBag.Show = show;
            EduQualPartialViewModel e = new EduQualPartialViewModel()
            {
                Colleges = ApplicationManager.GetDropDown<College>(db.College),
                Degrees = ApplicationManager.GetDropDown<Degree>(db.Degree),
                QualificationTypes = ApplicationManager.GetDropDown<QualificationType>(db.QualificationType),
                Univeristies = ApplicationManager.GetDropDown<University>(db.University)
            };
            return PartialView(e);
        }
    }
}