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
    }
}
