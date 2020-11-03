using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Univer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Univer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {

        private readonly UniverDbContext _context;

        public ScheduleController(UniverDbContext context)
        {
            _context = context;
        }
        // GET: api/<ScheduleController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Schedule>>> GetSchedules()
        {
            return await _context.Schedule.ToListAsync();
        }

        // GET api/<ScheduleController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Schedule>> GetSchedule(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }

        // POST api/<ScheduleController>
        [HttpPost]
        public async Task<ActionResult<Schedule>> CreateSchedule(Schedule schedule)
        {
            _context.Schedule.Add(schedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSchedules), new { id = schedule.Id }, schedule);
        }

        // PUT api/<ScheduleController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSchedule(int id, Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(schedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                if (!ScheduleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }

        // DELETE api/<ScheduleController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Schedule>> DeleteSchedule(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }

            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();

            return schedule;
        }
    }
}
