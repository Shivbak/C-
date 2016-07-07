using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPartyInvitations.Models;

namespace MVCPartyInvitations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                //TO DO: email response to party host
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is validation error
                return View();
            }
            
        }
    }
}