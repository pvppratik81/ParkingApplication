using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ParkingWebService.Models;

namespace ParkingWebService.Controllers
{
    public class ReleaseSlotController : ApiController
    {
        [HttpPost]
        [Route("api/ReleaseSlot")]
        public bool ReleaseSlot([FromBody] ReleaseSlot objSlotEquest)
        {
            bool retval = true;
            try
            {
                
                //List<ReleaseSlot> objList = new List<ReleaseSlot>();
                ReleaseSlot rs = new ReleaseSlot();
                rs.ParkingSlotId = 10;
                rs.ReleasedDate = System.DateTime.Today;
                // looking for set value by entity service as project from team mate
            }
            catch(System.Exception ex)
            {
                retval = false;
            }
            return retval;
        }
    }
}
