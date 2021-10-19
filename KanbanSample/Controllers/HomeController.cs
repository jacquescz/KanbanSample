using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KanbanSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var db = new Models.ApplicationDBConext();

            List<Models.PersonState> personStates = db.PersonStates.ToList();
            List<Models.Person> people = db.People.ToList();

            Models.HomeIndexViewModel model = new Models.HomeIndexViewModel()
            {
                PersonStates = personStates,
                People = people
            };


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}