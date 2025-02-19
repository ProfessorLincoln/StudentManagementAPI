using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using StudentManagementAPI.Data;

using StudentManagementAPI.Models;



namespace StudentManagementAPI.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class StudentsController : ControllerBase

    {

        private readonly StudentManagementContext _context;



        public StudentsController(StudentManagementContext context)

        {

            _context = context;

        }



        // GET: api/Students 

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()

        {

            return await _context.Students.ToListAsync();

        }



        // GET: api/Students/5 

        [HttpGet("{id}")]

        public async Task<ActionResult<Student>> GetStudent(int id)

        {

            var student = await _context.Students.FindAsync(id);



            if (student == null)

            {

                return NotFound();

            }



            return student;

        }



        // POST: api/Students 

        [HttpPost]

        public async Task<ActionResult<Student>> PostStudent(Student student)

        {

            _context.Students.Add(student);

            await _context.SaveChangesAsync();



            return CreatedAtAction("GetStudent", new { id = student.StudentID }, student);

        }



        // PUT: api/Students/5 

        [HttpPut("{id}")]

        public async Task<IActionResult> PutStudent(int id, Student student)

        {

            if (id != student.StudentID)

            {

                return BadRequest();

            }



            _context.Entry(student).State = EntityState.Modified;

            await _context.SaveChangesAsync();



            return NoContent();

        }



        // DELETE: api/Students/5 

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteStudent(int id)

        {

            var student = await _context.Students.FindAsync(id);

            if (student == null)

            {

                return NotFound();

            }



            _context.Students.Remove(student);

            await _context.SaveChangesAsync();



            return NoContent();

        }

    }

}