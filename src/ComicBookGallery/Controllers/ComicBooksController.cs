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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {

                return Redirect("/");

            }
            return Content("Hello from the Comic Books controller!");
            
            

        }


    }
}