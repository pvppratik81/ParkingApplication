using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingWebService.Models
{
    public class ReleaseSlot
    {
        public int ParkingSlotId { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
}