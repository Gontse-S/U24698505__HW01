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
        public string IconPath { get; set; }
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
    }
}