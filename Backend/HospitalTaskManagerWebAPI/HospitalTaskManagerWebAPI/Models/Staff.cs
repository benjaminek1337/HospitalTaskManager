using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class Staff
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNr { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public bool OnSite { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}
