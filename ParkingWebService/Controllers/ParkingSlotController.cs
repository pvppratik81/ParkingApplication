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
            slotResponse objResp;
            try
            {
                objResp = new slotResponse();
                return objResp;
            }
            catch (Exception ex)
            {
                objResp = new slotResponse();
                objResp.statusCode = "NOK";
                return objResp;
            }

        }

        [HttpPost]
        [Route("api/employeecancelslotrequest")]
        public slotResponse Employeecancelrequestslot([FromBody] SlotRequest objSlotEquest)
        {
            slotResponse objResp;
            try
            {
                objResp = new slotResponse();
                return objResp;
            }
            catch (Exception ex)
            {
                objResp = new slotResponse();
                objResp.statusCode = "NOK";
                return objResp;
            }
        }

        [HttpPost]
        [Route("api/employeeacceptslotrequest")]
        public slotResponse Employeeacceptrequestslot([FromBody] SlotRequest objSlotEquest)
        {
            slotResponse objResp;
            try
            {
                objResp = new slotResponse();
                return objResp;
            }
            catch (Exception ex)
            {
                objResp = new slotResponse();
                objResp.statusCode = "NOK";
                return objResp;
            }
        }
    }
}
