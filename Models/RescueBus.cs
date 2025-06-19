using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U24698505__HW01.Models
{
    public class RescueBus
    {
        public List<ServiceOption> Services { get; set; }
    }
    public class ServiceOption
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }

    public class Driver
    {
        public string Name { get; set; }
        public string ImageFile { get; set; }
        public string Phone { get; set; }
    }

    public class Vehicle
    {
        public string Name { get; set; }
        public string ImageFile { get; set; }
        public string Registration { get; set; }
    }


   
    public class Booking
    {
        public string BookingID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string PickUpTime { get; set; }
        public string Reason { get; set; }
        public string Vehicle { get; set; }
        public string Driver { get; set; }
        public string PickUpAddress { get; set; }
        public string ServiceType { get; set; }
        public string BookingDate { get; set; }
        public string DriverImage { get; set; }
        public string VehicleImage { get; set; }
        public string VehicleRegNumber { get; set; }

        public bool IsSOS { get; set; } // Indicates if the booking is for a Service Option
    }
}
