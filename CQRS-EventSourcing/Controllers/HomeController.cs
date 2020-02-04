using CQRS_EventSourcing.Core;
using CQRS_EventSourcing.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQRS_EventSourcing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventBus _eventBus;
        public HomeController(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public ActionResult Index()
        {
            var eve = new CategoryCreatedEvent(1);
            _eventBus.Publish(eve);

            return View();
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