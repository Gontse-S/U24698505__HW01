using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U24698505__HW01.Models;

namespace U24698505__HW01.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Homepage()
        {
            return View();
        }

        public ActionResult Ride()
        {
            return View();
        }

        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult SelectService()
        {
            var model = new RescueBus
            {
                Services = new List<ServiceOption>
           {
    new ServiceOption
    {
        Title = "ALS (Advances Life Support)",
        Description = "ALS ambulance is staffed by a Paramedic and is used to transport patients who require high level of care",
        IconPath = Url.Content("~/Content/Images/ALS.jpg")
    },
    new ServiceOption
    {
        Title = "BLS (Basic Life Support)",
        Description = "BLS ambulance provides transport to patients who are in a non life threatening condition",
        IconPath = Url.Content("~/Content/Images/BLS.jpg")
    },
    new ServiceOption
    {
        Title = "Patient Transport",
        Description = "The most basic type of transport for patients requiring ambulatory support to and from the hospital",
        IconPath = Url.Content("~/Content/Images/transport.jpg")
    },
    new ServiceOption
    {
        Title = "Medical Utility Vehicle",
        Description = "A state-of-the-art small or large van that is designed to facilitate the movement and transport of patients",
        IconPath = Url.Content("~/Content/Images/van.jpg")
    },
    new ServiceOption
    {
        Title = "Event Medical Ambulance",
        Description = "Ambulances that are stationed at events, such as concerts, sports games, and festivals, to provide medical assistance",
        IconPath = Url.Content("~/Content/Images/event.jpg")
    },
    new ServiceOption
    {
        Title = "Air ambulance",
        Description = "Air ambulance help in the transfer of patients across long distances in both emergency and non-emergency situations",
        IconPath = Url.Content("~/Content/Images/airam.jpg")
    }
}
            };

            return View(model);
        }
        public ActionResult BookingForm(string service)
        {
            ViewBag.ServiceType = service;
            return View();
        }

        public ActionResult BookingConfirmed()
        {
            return View();
        }

    
    }
}