﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleService.Models
{
    public class Vehicle
    {
        public int Vehicle_Id { get; set; }
        public string Vehicle_Cmpy { get; set; }
        public double Rent_per_month { get; set; }

        

       
    }
}
