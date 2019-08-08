using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestWebApiPS.Models
{
    public class ParkingSlotModels
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

        public class Employee
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string middleName { get; set; }
            public string emailAddress { get; set; }
            public string phone { get; set; }
        }


    }
}

}