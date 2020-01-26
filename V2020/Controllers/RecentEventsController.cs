using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V2020.Controllers
{
    public class RecentEventsController : Controller
    {
        // GET: RecentEvents
        public ActionResult Index()
        {
            return View();
        }
    }
}