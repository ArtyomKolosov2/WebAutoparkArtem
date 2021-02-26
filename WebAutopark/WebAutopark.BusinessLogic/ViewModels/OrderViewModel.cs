﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutopark.DataAccess.Models;

namespace WebAutopark.BusinessLogic.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public VehicleViewModel Vehicle { get; set; }
        public int VehicleId { get; set; }
        public string Description { get; set; }
    }
}