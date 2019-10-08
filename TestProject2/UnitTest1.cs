using System.Net.Http;
using System.Threading.Tasks;
using WebApplication;
using WebApplication.Model;
using Xunit;

namespace TestProject2
{
    public class UnitTest1 : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;
        private readonly ApplicationDbContext _db;
        private readonly HttpClient _client;
        
        public UnitTest1(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
            _db = factory.Services.GetService(typeof(ApplicationDbContext)) as
                ApplicationDbContext;
        }
        
        [Fact]
        public async Task Test1()
        {
            _db.Vehicle.Add(new Vehicle()
            {
                VehicleId = 68
            });
            _db.SaveChanges();

            var response = await _client.GetAsync("/test");
        }
    }
}