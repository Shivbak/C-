using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRecords.Models;

namespace MVCRecords.Controllers
{
    public class HomeController : Controller
    {
        List<Album> album = new List<Album>();
        // GET: Home
        public ActionResult Index()
        {
            Album album1 = new Album("Dark side of Moon", "Pink Floyd", "Vinyl", 9.99M);
            album.Add(album1);

            Album album2 = new Album("Tubular Bells","Mike Oldfield","Vinyl",8.99M);
            album.Add(album2);

            Album album3 = new Album("Back to Black", "Amy Winehouse", "CD",7.99M);
            album.Add(album3);

            return View(album);
        }
    }
}