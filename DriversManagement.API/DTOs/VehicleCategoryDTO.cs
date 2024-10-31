using DriversManagement.API.Models;

namespace DriversManagement.API.DTOs
{
    public class VehicleCategoryDTO
    {
        public string Symbol { get; set; }
        public int Age { get; set; }
        public int Mass { get; set; }

        public ICollection<Driver> Drivers { get; set; }
    }
}
