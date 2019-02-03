using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using manja.Models;

namespace manja.Controllers
{
    public class NewsController : Controller
    {
        // GET: News/AllNews
        public ActionResult AllNews()
        {
            var news = new News() { title = "moshak abi", text = "12.11.97" };
            return View(news);
        }
    }
}