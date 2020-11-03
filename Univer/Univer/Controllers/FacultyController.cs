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
    public class FacultyController : ControllerBase
    {

        private readonly UniverDbContext _context;

        public FacultyController(UniverDbContext context)
        {
            _context = context;
        }
        // GET: api/<FacultyController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faculty>>> GetFaculties ()
        {
            return await _context.Faculty.ToListAsync();
        }

        // GET api/<FacultyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faculty>> GetFaculty(int id)
        {
            var faculty = await _context.Faculty.FindAsync(id);

            if (faculty == null)
            {
                return NotFound();
            }

            return faculty;
        }
    }
}
