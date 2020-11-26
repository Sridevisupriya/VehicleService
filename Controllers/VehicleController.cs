using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleService.Models;
using VehicleService.Repository;

namespace VehicleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _IVehicleRepository;
        public VehicleController(IVehicleRepository Repo)
        {
            this._IVehicleRepository = Repo;
        }

        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            try
            {
               
                IEnumerable<Vehicle> Vlist = _IVehicleRepository.GetAll();
                return Ok(Vlist);
            }
            catch
            {
               
                return new NoContentResult();
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Vlist = _IVehicleRepository.GetById(id);
                return new OkObjectResult(Vlist);
            }
            catch
            {
                return new NoContentResult();
            }

        }
    }
}
