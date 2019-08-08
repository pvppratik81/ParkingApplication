using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingWebService.Models
{
    public class BaseRespone
    {
        public string statusCode { get; set; }
        public string errorCode { get; set; }
        public string errorDescription { get; set; }
    }
    public class SlotRequest
    {
        public int employeeId { get; set; }
        public DateTime requestedDate { get; set; }

    }

    public class slotResponse : BaseRespone
    {

    }



    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int role { get; set; }
    }
}