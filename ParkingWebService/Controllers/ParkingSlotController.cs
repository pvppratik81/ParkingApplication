using ParkingWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingWebService.Controllers
{
    public class ParkingSlotController : ApiController
    {

        [HttpPost]
        [Route("api/employeeslotrequest")]
        public slotResponse Employeerequestslot([FromBody] SlotRequest objSlotEquest)
        {
            slotResponse onjResp = new slotResponse();
            return onjResp;
        }
    }
}
