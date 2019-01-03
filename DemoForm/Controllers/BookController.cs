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
            //model.LanguageCode = "DK";
            SetupAvailableLanguages(model);
            return View(model);
        }

        void SetupAvailableLanguages(ViewModels.BookViewModel model)
        {
            model.AvailableLanguages = new List<SelectListItem>
            {
                new SelectListItem{ Value=null, Text="..välj ett språk.."  },
                new SelectListItem{ Value="SE", Text="Svenska"  },
                new SelectListItem{ Value="FI", Text="Finska"  },
                new SelectListItem{ Value="DK", Text="Danska"  },
            };
        }

        [HttpPost]
        public ActionResult AddNew(ViewModels.BookViewModel model)
        {
            SetupAvailableLanguages(model);

            if (string.IsNullOrEmpty(model.Title))
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
