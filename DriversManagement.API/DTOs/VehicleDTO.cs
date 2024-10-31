using DriversManagement.API.Models;

namespace DriversManagement.API.DTOs
{
    public class VehicleDTO
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public int FuelCapacity { get; set; }
        public int DriverId { get; set; }
    }
}
