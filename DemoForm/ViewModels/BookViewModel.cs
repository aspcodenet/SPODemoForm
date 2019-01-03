using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForm.ViewModels
{
    public class BookViewModel
    {
        [Required]
        public string Title { get; set; }
        
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public string Publisher { get; set; }


        public List<SelectListItem> AvailableLanguages { get; set; }
        [Required]
        public string LanguageCode { get; set; }

        public bool IsSaved { get; set; }
    }
}