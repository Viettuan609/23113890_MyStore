using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23dh113890_MyStore.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin/Categories/Detail/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Admin/Categories/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}