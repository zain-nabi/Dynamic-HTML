using Dynamic_Input.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dynamic_Input.ViewModel
{
    public class VehicleViewModel
    {
        public List<Vehicle> Vehicles { get; set; }
        public string DynamicTextBoxValues { get; set; }
    }
}
