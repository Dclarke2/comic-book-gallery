
using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist(){Name = "Dan Slott", Role = "Script"},
                    new Artist(){Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist(){Name = "Victor Olazaba", Role = "Inks"},
                    new Artist(){Name = "Edgar Delgado", Role = "Colors"},
                    new Artist(){Name = "Chris Eliopoulos", Role = "Letters"},
                }
            };

            return View(comicBook); //<- Passing comicBook model instance to view.
        }


    }
}