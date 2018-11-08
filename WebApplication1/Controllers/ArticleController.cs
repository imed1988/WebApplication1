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
            //return new EmptyResult();
            //return RedirectToAction("Index","Home", new {page=1, sortBy="name"} );
        }


        public ActionResult Edit(int id)
        {

            return Content("id"+id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex : {0}&sortBy : {1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month); 
        }

        //ByReleaseDatechar

        public ActionResult ByReleaseDatechar(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //ByReleaseDatePeriod

        public ActionResult ByReleaseDatePeriod(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}