using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    public class Test : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly VehicleService _vehicleService;

        public Test(ApplicationDbContext db, VehicleService vehicleService)
        {
            _db = db;
            _vehicleService = vehicleService;
        }
        
        [HttpGet]
        [Route("/test")]
        public async Task<IActionResult> Index()
        {
            var vehicle = await _vehicleService.GetVehicle(68);

            vehicle.Odometer.Add(new Odometer()
            {
                Reading = 342797
            });
            _db.SaveChanges();
            var vehicle2 = _db.Vehicle.Include(x => x.Odometer).First(x => x.VehicleId == 68);
            return new EmptyResult();
        }
    }
}