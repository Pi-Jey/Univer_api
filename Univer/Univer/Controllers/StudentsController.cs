using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Univer.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Univer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly UniverDbContext _context;

        public StudentsController(UniverDbContext context)
        {
            _context = context;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Students>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Students>> GetStudents(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

    }
}
