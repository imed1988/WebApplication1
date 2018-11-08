using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Random()
        {
            var article = new Article() { DesignationArticle = "SOUFFI GAFSA GI" };
            return View(article);
            //return Content("Hello World");
            //return HttpNotFound();
        }
    }
}