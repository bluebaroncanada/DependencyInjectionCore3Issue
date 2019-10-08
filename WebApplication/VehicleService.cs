using System.Threading.Tasks;
using WebApplication.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplication
{
    public class VehicleService
    {
        private readonly ApplicationDbContext _db;

        public VehicleService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Vehicle> GetVehicle(int vehicleId) => await _db.Vehicle.FirstAsync(x => x.VehicleId == vehicleId);
    }
}