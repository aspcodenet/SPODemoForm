﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoForm.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }

        public bool IsSaved { get; set; }
    }
}