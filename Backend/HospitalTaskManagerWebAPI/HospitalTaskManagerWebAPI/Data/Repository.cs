using HospitalTaskManagerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly HospitalTaskManagerContext context;
        public Repository(HospitalTaskManagerContext context)
        {
            this.context = context;
        }

        public List<AccessLog> GetAllAccesslogs()
        {
            return context.AccessLog.ToList();
        }
    }
}
