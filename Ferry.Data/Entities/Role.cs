using System;
using System.Collections.Generic;
using System.Text;

namespace Ferry.Data
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
