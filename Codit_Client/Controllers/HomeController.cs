using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codit_Client.Models;
using Codit_Client.Services;
namespace Codit_Client.Controllers
{
    public class HomeController : Controller
    {

        private MailService _mailService = new MailService(); 

            public ActionResult Index()
        {
            return View(new Client());
        }


        [HttpPost]
        public ActionResult SendInformation(Client model)
        {
            _mailService.SendMail(model);
            return View("Index", new Client());
        }

       
    }
}