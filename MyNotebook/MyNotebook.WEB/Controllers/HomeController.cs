using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyNotebook.WEB.Models;
using MyNoteebook.BLL.Interfaces;

namespace MyNotebook.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactManager contactManager;

        public HomeController(IContactManager contactManager)
        {
            this.contactManager = contactManager;
        }

        public ActionResult Index()
        {
            var contactList = contactManager.GetAllContacts();
            return View(contactList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}