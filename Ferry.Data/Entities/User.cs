using System;
using System.Collections.Generic;
using System.Text;

namespace Ferry.Data
{
    public class User
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
