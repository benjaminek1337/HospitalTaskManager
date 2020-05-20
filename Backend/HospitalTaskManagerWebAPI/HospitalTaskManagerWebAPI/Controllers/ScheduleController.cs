﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalTaskManagerWebAPI.Data;
using HospitalTaskManagerWebAPI.Models;
using HospitalTaskManagerWebAPI.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace HospitalTaskManagerWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IRepository repo;
        public ScheduleController(IRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("Staff")]
        public ActionResult<IEnumerable<Staff>> GetStaff()
        {
            return repo.GetTodaysStaff();
        }

        [HttpGet]
        [Route("Schedules/{date}")]
        public ActionResult<List<Schedule>> GetSchedules(DateTime date)
        {
            return repo.GetTodaysSchedule(date);
        }

        [HttpGet]
        [Route("Procedures/{date}")]
        public ActionResult<IEnumerable<Procedure>> GetProcedures(DateTime date)
        {
            return repo.GetTodaysProcedures(date);
        }

        [HttpGet]
        [Route("Departments")]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            return repo.GetDepartments();
        }

        [HttpGet]
        [Route("ScheduledProcedures/{date}")]
        public ActionResult<IEnumerable<ScheduledProcedure>> GetScheduledProcedures(DateTime date)
        {
            return repo.GetTodaysScheduledProcedures(date);
        }
        [HttpGet]
        [Route("initdata/{date}")]
        public ActionResult<AllDataViewModel> GetSchedulerInitialData(DateTime date)
        {
            //var json = JsonConvert.SerializeObject(repo.GetInitScheduleData(date), Formatting.Indented);
            //return json;

            return repo.GetInitScheduleData(date);
        }

        [HttpPut("markprocedureashandled/{id}")]
        public void MarkProcedureAsHandled(int id, [FromBody]Procedure procedure)
        {
            if(id == procedure.ID)
                repo.MarkProcedureAsHandled(procedure);
        }

        [HttpPut("markprocedureasunhandled/{id}")]
        public void MarkProcedureAsUnhandled(int id, [FromBody]Procedure procedure)
        {
            if (id == procedure.ID)
                repo.MarkProcedureAsUnhandled(procedure);
        }

    }   
}