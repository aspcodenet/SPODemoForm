using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForm.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public ActionResult AddNew()
        {
            var model = new ViewModels.BookViewModel();
            model.Language = "Svenska";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNew(ViewModels.BookViewModel model)
        {
            if(string.IsNullOrEmpty(model.Title))
            {
                return View(model);
            }


            ///Save to database
            model.IsSaved = true;
            return View(model);

            //return View(model);
        }

    }
}
