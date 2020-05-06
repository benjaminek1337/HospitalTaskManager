using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalTaskManagerWebAPI.Data;
using HospitalTaskManagerWebAPI.Models;

namespace HospitalTaskManagerWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccesslogsController : ControllerBase
    {
        private readonly IRepository repo;

        public AccesslogsController(IRepository repo)
        {
            this.repo = repo;
        }

        // GET: api/Accesslogs

        // GET: api/Accesslogs/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Accesslog>> GetAccesslog(int id)
        //{
        //    var accesslog = await _context.Accesslog.FindAsync(id);

        //    if (accesslog == null)
        //    {
        //        return NotFound();
        //    }

        //    return accesslog;
        //}

        //// PUT: api/Accesslogs/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAccesslog(int id, Accesslog accesslog)
        //{
        //    if (id != accesslog.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(accesslog).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AccesslogExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Accesslogs
        //[HttpPost]
        //public async Task<ActionResult<Accesslog>> PostAccesslog(Accesslog accesslog)
        //{
        //    _context.Accesslog.Add(accesslog);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAccesslog", new { id = accesslog.ID }, accesslog);
        //}

        //// DELETE: api/Accesslogs/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Accesslog>> DeleteAccesslog(int id)
        //{
        //    var accesslog = await _context.Accesslog.FindAsync(id);
        //    if (accesslog == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Accesslog.Remove(accesslog);
        //    await _context.SaveChangesAsync();

        //    return accesslog;
        //}

        //private bool AccesslogExists(int id)
        //{
        //    return _context.Accesslog.Any(e => e.ID == id);
        //}
    }
}
