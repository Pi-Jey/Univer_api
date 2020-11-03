using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univer.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public int Department_id { get; set; }
        public string Department_name { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
    }
}
