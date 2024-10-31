using AutoMapper;
using DriversManagement.API.DTOs;
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
        private readonly IMapper mapper;
        public VehicleController(IVehicleService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet("all{direction}")]
        public ActionResult<ICollection<VehicleDTO>> GetOrderedVehicles([FromRoute] string direction, [FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            try
            {
                return Ok(service.GetOrdered(direction, skip, take).Select(mapper.Map<VehicleDTO>));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("vehicle/year/{year}/model/{model}")]
        public ActionResult<VehicleDTO> GetVehicleByDemands([FromRoute]int year, [FromRoute] string model)
        {
            try
            {
                return Ok(mapper.Map<VehicleDTO>(service.GetVehicleByYearAndModel(year,model)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
