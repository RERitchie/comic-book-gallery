﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "Hello from the Comic Book Controller. It Works!!"

            };
        }
    }
}