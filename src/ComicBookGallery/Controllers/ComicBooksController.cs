using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller      //<-- Must be called Controller & Inherit from controller base class. ComicBooksController to handle request...
    {
        public ActionResult Detail()  //Ability to view the details from comic book gallery. Adding Action to controller.
        {
            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";

            var artists = new string[]
            {
                 "Script: Dan Slott",
                 "Pencils: Humberto Ramos",
                 "Inks: Victor Olazaba",
                 "Colors: Edgar Delgado",
                 "Letters: Chris Eliopoulos"
            };

            return View();
        }


    }
}