using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleService.Models;

namespace VehicleService.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> vehicle_list = new List<Vehicle>();
        public VehicleRepository()
        { 
            vehicle_list.Add( new Vehicle { Vehicle_Id=1 , Vehicle_Cmpy="Honda" ,Rent_per_month=500});
            vehicle_list.Add(new Vehicle { Vehicle_Id = 2, Vehicle_Cmpy = "Fiat", Rent_per_month = 1500 });
            vehicle_list.Add(new Vehicle { Vehicle_Id = 3, Vehicle_Cmpy = "Suzuki", Rent_per_month = 2500 });
            vehicle_list.Add(new Vehicle { Vehicle_Id = 4, Vehicle_Cmpy = "Hyndai", Rent_per_month = 3500 });
        }


        public IEnumerable<Vehicle> GetAll()
        {
            return vehicle_list;
        }

        public Vehicle GetById(int vehicle_id)
        {
            foreach (var item in vehicle_list)
            {
                if (item.Vehicle_Id == vehicle_id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
