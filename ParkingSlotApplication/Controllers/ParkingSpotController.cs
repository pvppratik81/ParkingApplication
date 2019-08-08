using Microsoft.AspNetCore.Mvc;

namespace ParkingSlotApplication.Controllers
{
    [Route("api/[controller]")]
    public class ParkingSpotController : Controller
    {
        [HttpPost("[action]")]
        public void RequestSpot(int employeeId)
        {
            //to do
        }
        [HttpPost("[action]")]
        public void AcceptSpot(int employeeId)
        {
            //to do
        }
        [HttpPost("[action]")]
        public void RequesDeclineSpottSpot(int employeeId)
        {
            //to do
        }
        [HttpPost("[action]")]
        public void ReleaseSpot(int employeeId)
        {
            //to do
        }
    }
}
