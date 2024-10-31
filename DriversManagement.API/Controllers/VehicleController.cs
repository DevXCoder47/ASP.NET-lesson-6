using DriversManagement.API.Interfaces;
using DriversManagement.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriversManagement.API.Controllers
{
    [Route("api/vehicles")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService service;
        public VehicleController(IVehicleService service)
        {
            this.service = service;
        }
        [HttpGet("all{direction}")]
        public ActionResult<ICollection<Vehicle>> GetOrderedVehicles([FromRoute] string direction, [FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            try
            {
                return Ok(service.GetOrdered(direction, skip, take));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("vehicle/year/{year}/model/{model}")]
        public ActionResult<Vehicle> GetVehicleByDemands([FromRoute]int year, [FromRoute] string model)
        {
            try
            {
                return Ok(service.GetVehicleByYearAndModel(year,model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
