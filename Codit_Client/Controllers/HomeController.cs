using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codit_Client.Models;
namespace Codit_Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            return View(new Client());
        }

       
        [HttpPost]
        public ActionResult SendInformation()
        {


            return View("Index",new Client());
        }
    }
}