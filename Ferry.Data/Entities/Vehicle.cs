using System;
using System.Collections.Generic;
using System.Text;

namespace Ferry.Data
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlateNumber { get; set; }
        public VehicleCategory VehicleCategory { get; set; }
    }
}
