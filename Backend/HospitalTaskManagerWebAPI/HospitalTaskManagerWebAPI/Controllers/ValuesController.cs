using HospitalTaskManagerWebAPI.Data;
using HospitalTaskManagerWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HospitalTaskManagerWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRepository repo;

        public ValuesController(IRepository repo)
        {
            this.repo = repo;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Staff>> Get()
        {
            return repo.GetTodaysStaff();
        }

        [HttpGet]
        [Route("Schedules")]
        public ActionResult<List<Schedule>> GetSchedule()
        {
            return repo.GetTodaysSchedule();
        }
        [HttpGet]
        [Route("Procedures")]
        public ActionResult<List<Procedure>> GetProcedures()
        {
            return repo.GetTodaysProcedures();
        }

        [HttpGet]
        [Route("ScheduledProcedures")]
        public ActionResult<List<ScheduledProcedure>> GetScheduledProcedures()
        {
            return repo.GetScheduledProcedures();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
