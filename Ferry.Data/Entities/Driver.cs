using System;
using System.Collections.Generic;
using System.Text;

namespace Ferry.Data
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<VehicleCategory> Skills { get; set; }
    }
}
