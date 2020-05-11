using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<Procedure> Procedures { get; set; }
    }
}
