using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class AccessLog
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string Department { get; set; }
        public bool OnSite { get; set; }
    }
}
