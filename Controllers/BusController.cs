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
       

        public ActionResult Homepage()
        {
            return View();
        }

      

        public ActionResult Manage()
        {
            var model = new RescueBus
            {
                Services = GetServiceOptions()
            };
            return View(model);
        }

        private List<ServiceOption> GetServiceOptions()
        {
            return new List<ServiceOption>
            {
                new ServiceOption
                {
                    Title = "ALS (Advanced Life Support)",
                    Description = "ALS ambulance is staffed by a Paramedic and is used to transport patients who require high level of care",
                    ImageUrl = Url.Content("~/Content/Images/ALS.jpg"),
                    Drivers = new List<Driver>
                    {
                        new Driver { Name = "Billie Ellish", ImageFile = "billie.jpg", Phone = "011-100-1111" },
                        new Driver { Name = "Doja Cat", ImageFile = "doja.jpg", Phone = "081-100-1112" }
                    },
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle { Name = "ALS Type 1", ImageFile = "als1.jpg"},
                        new Vehicle { Name = "ALS Type 2", ImageFile = "als2.jpg"}
                    }
                },
                new ServiceOption
                {
                    Title = "BLS (Basic Life Support)",
                    Description = "BLS ambulance provides transport to patients who are in a non life threatening condition",
                    ImageUrl = Url.Content("~/Content/Images/BLS.jpg"),
                    Drivers = new List<Driver>
                    {
                        new Driver { Name = "Kendrick Lamar", ImageFile = "kendrick.jpg", Phone = "082-200-2221" },
                        new Driver { Name = "Jorja Smith", ImageFile = "jorja.jpg", Phone = "082-200-2222"}
                    },
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle { Name = "BLS Van 1", ImageFile = "bls1.jpg", Registration = "V-BLS-001" },
                        new Vehicle { Name = "BLS Van 2", ImageFile = "bls2.jpg", Registration = "V-BLS-002" }
                    }
                },
                new ServiceOption
                {
                    Title = "Patient Transport",
                    Description = "The most basic type of transport for patients requiring ambulatory support to and from the hospital",
                    ImageUrl = Url.Content("~/Content/Images/transport.jpg"),
                    Drivers = new List<Driver>
                    {
                        new Driver { Name = "Zesty Drake", ImageFile = "drake.jpg", Phone = "083-300-3331" },
                        new Driver { Name = "Zoe Kravitz", ImageFile = "zoe.jpg", Phone = "083-300-3332" }
                    },
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle { Name = "PT Van A", ImageFile = "pt1.jpg", Registration = "V-PT-001" },
                        new Vehicle { Name = "PT Van B", ImageFile = "pt2.jpg", Registration = "V-PT-002" }
                    }
                },
                new ServiceOption
                {
                    Title = "Medical Utility Vehicle",
                    Description = "A state-of-the-art small or large van that is designed to facilitate the movement and transport of patients",
                    ImageUrl = Url.Content("~/Content/Images/van.jpg"),
                    Drivers = new List<Driver>
                    {
                        new Driver { Name = "Uncle Waffles", ImageFile = "waffles.jpg", Phone = "084-400-4441" },
                        new Driver { Name = "Keith Powers", ImageFile = "keith.jpg", Phone = "084-400-4442" }
                    },
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle { Name = "MUV Van X", ImageFile = "muv.jpg", Registration = "V-MUV-001" },
                        new Vehicle { Name = "MUV Van Y", ImageFile = "muv2.jpg", Registration = "V-MUV-002" }
                    }
                },
                new ServiceOption
                {
                    Title = "Event Medical Ambulance",
                    Description = "Ambulances that are stationed at events, such as concerts, sports games, and festivals, to provide medical assistance",
                    ImageUrl = Url.Content("~/Content/Images/event.jpg"),
                    Drivers = new List<Driver>
                    {
                        new Driver { Name = "Dwanye Johnson", ImageFile = "dwanye.jpg", Phone = "085-500-5551"},
                        new Driver { Name = "John Cena", ImageFile = "john cena.jpg", Phone = "085-500-5552" }
                    },
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle { Name = "Event Truck 1", ImageFile = "etruck1.jpg", Registration = "V-EVT-001" },
                        new Vehicle { Name = "Event Truck 2", ImageFile = "eTruck2.jpg", Registration = "V-EVT-002" }
                    }
                },
                new ServiceOption
                {
                    Title = "Air ambulance",
                    Description = "Air ambulance help in the transfer of patients across long distances in both emergency and non-emergency situations",
                    ImageUrl = Url.Content("~/Content/Images/airam.jpg"),
                    Drivers = new List<Driver>
                    {
                        new Driver { Name = "Erykah Baduh", ImageFile = "badu.jpg", Phone = "086-600-6661" },
                        new Driver { Name = "Michael Jackson", ImageFile = "michael.jpg", Phone = "086-600-6662" }
                    },
                    Vehicles = new List<Vehicle>
                    {
                        new Vehicle { Name = "Air Ambulance A", ImageFile = "air1.jpg", Registration = "V-AIR-001" },
                        new Vehicle { Name = "Air Ambulance B", ImageFile = "air2.jpg", Registration = "V-AIR-002" }
                    }
                }
            };
        }


        public ActionResult SelectService()
        {
            var model = new RescueBus
            {
                Services = GetServiceOptions()
            };

            return View(model);
        }
        public ActionResult BookingForm(string service)
        {
            if (string.IsNullOrEmpty(service))
                return RedirectToAction("SelectService");

            var allServices = GetServiceOptions();
            var selectedService = allServices.FirstOrDefault(s => s.Title == service);

            if (selectedService == null)
                return HttpNotFound();

            return View(selectedService);
        }

        public ActionResult BookingConfirmed()
        {
            return View();
        }

        public ActionResult Ride()
        {
           
        
        

            return View();
        }


    }


    public JsonResult GetAllServices()
{
    var services = GetServiceOptions();
    return Json(services, JsonRequestBehavior.AllowGet);
}



}