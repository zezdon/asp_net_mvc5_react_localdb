using ReactAspx.Models.Data;
using ReactAspx.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactAspx.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            // Declare list of PageVM
            List<PageVM> pagesList;

            using (DBNAME db = new DBNAME())
            {
                // Init the list
                pagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }
            // Return view with list
            return View(pagesList);
        }
    }
}