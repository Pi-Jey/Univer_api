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
    public class TeachersController : ControllerBase
    {
        private readonly UniverDbContext _context;

        public TeachersController(UniverDbContext context)
        {
            _context = context;
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teachers>> GetTeacher(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
        }

    }
}
