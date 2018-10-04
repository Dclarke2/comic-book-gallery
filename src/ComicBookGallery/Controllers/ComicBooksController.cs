
using ComicBookGallery.Data;
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
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);


        }
        public ActionResult Detail(int? id)  //Ability to view the details from comic book gallery. Adding Action to controller.
        {
            if (id == null)
            {
                return HttpNotFound();//If no ID number is entered in URL you'll get the HTTP not found error!
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook); //<- Passing ComicBook model instance to view method call.
        }


    }
}