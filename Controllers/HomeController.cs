using Assignment.Models;
using Sitecore.Data;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Header()
        {
            var Model = new Header()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/Home/Header.cshtml", Model);
        }
        public ActionResult Aboutus()
        {
            var Model = new Aboutus()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };
                
            return View("/Views/Home/Aboutus.cshtml", Model);
        }

        public ActionResult Service()
        {
            var Model = new Service()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/Home/Service.cshtml", Model);
        }

        public ActionResult Testimonials()
        {
            var Model = new Testimonials()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/Home/Testimonials.cshtml", Model);
        }

        public ActionResult Footer()
        {
            var Model = new Footer()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/Home/Footer.cshtml", Model);
        }


    }
}