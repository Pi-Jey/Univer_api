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
    public class GroupsController : ControllerBase
    {

        private readonly UniverDbContext _context;

        public GroupsController(UniverDbContext context)
        {
            _context = context;
        }
        // GET: api/<GroupController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Groups>>> GetFaculties()
        {
            return await _context.Groups.ToListAsync();
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Groups>> GetFaculty(int id)
        {
            var group = await _context.Groups.FindAsync(id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }
    }
}
