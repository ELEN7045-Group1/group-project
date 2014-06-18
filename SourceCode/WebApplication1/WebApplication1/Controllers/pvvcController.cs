using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class pvvcController : Controller
    {
        // GET: pvvc
        public ActionResult Index()
        {
            return View();
        }
        
        public double Addition(double Val1, double Val2)
        {
            return Val1 + Val2;
        }
    }
}