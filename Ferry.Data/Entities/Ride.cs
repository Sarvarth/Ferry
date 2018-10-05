using System;
using System.Collections.Generic;
using System.Text;

namespace Ferry.Data
{
    public class Ride
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public Driver Driver { get; set; }
        public Location Source { get; set; }
        public Location Destination { get; set; }
        public DateTime RideStartTime { get; set; }
        public DateTime RideEndTime { get; set; }
        public IEnumerable<User> Riders { get; set; }
    }
}
