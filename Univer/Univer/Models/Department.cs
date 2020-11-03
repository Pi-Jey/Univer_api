using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univer.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int Faculty_id { get; set; }
        public string Faculty_name { get; set; }
        public string Name { get; set; }
        public string Short_Name { get; set; }
    }
}
