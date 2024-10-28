using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23dh113890_MyStore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin/Home/Detail/5
        public ActionResult Result(int id)
        {
            return View();
        }
        // GET: Admin/Home/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}