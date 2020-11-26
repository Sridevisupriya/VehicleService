using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleService.Models;

namespace VehicleService.Repository
{
   public  interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        Vehicle GetById(int Vehicle_id);
    }
}
