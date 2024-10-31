using DriversManagement.API.Interfaces;
using DriversManagement.API.Models;

namespace DriversManagement.API.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository repository;
        public VehicleService(IRepository repository)
        {
            this.repository = repository;
        }
        public ICollection<Vehicle> GetOrdered(string direction, int skip, int take)
        {
            switch (direction)
            {
                case "asc": return repository.GetAll<Vehicle>().OrderBy(v => v.Id).Skip(skip).Take(take).ToList();
                case "desc": return repository.GetAll<Vehicle>().OrderByDescending(v => v.Id).Skip(skip).Take(take).ToList();
                default: throw new Exception("Invalid direction");
            }
        }
        public Vehicle GetVehicleByYearAndModel(int year, string model)
        {
            return repository.GetAll<Vehicle>().First(v => v.Year == year && v.Model == model);
        }
    }
}
