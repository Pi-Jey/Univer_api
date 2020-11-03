using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univer.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Teacher_id { get; set; }
        public string Teacher_name { get; set; }
        public int Discipline_id { get; set; }
        public string Discipline_name { get; set; }
        public int Group_id { get; set; }
        public string Group_name { get; set; }
        public string Time { get; set; }
        public string Classroom { get; set; }
    }
}
