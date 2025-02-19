using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using StudentManagementAPI.Data;

using StudentManagementAPI.Models;



namespace StudentManagementAPI.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class SubjectsController : ControllerBase

    {

        private readonly StudentManagementContext _context;



        public SubjectsController(StudentManagementContext context)

        {

            _context = context;

        }



        // GET: api/Subjects 

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()

        {

            return await _context.Subjects.ToListAsync();

        }



        // GET: api/Subjects/5 

        [HttpGet("{id}")]

        public async Task<ActionResult<Subject>> GetSubject(int id)

        {

            var subject = await _context.Subjects.FindAsync(id);



            if (subject == null)

            {

                return NotFound();

            }



            return subject;

        }



        // POST: api/Subjects 

        [HttpPost]

        public async Task<ActionResult<Subject>> PostSubject(Subject subject)

        {

            _context.Subjects.Add(subject);

            await _context.SaveChangesAsync();



            return CreatedAtAction("GetSubject", new { id = subject.SubjectID }, subject);

        }



        // PUT: api/Subjects/5 

        [HttpPut("{id}")]

        public async Task<IActionResult> PutSubject(int id, Subject subject)

        {

            if (id != subject.SubjectID)

            {

                return BadRequest();

            }



            _context.Entry(subject).State = EntityState.Modified;

            await _context.SaveChangesAsync();



            return NoContent();

        }



        // DELETE: api/Subjects/5 

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteSubject(int id)

        {

            var subject = await _context.Subjects.FindAsync(id);

            if (subject == null)

            {

                return NotFound();

            }



            _context.Subjects.Remove(subject);

            await _context.SaveChangesAsync();



            return NoContent();

        }

    }

}

