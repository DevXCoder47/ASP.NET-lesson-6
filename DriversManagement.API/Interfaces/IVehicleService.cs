using DriversManagement.API.Models;

namespace DriversManagement.API.Interfaces
{
    public interface IVehicleService
    {
        ICollection<Vehicle> GetOrdered(string direction, int skip, int take);
        Vehicle GetVehicleByYearAndModel(int year, string model);
    }
}
