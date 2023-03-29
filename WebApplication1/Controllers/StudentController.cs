using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private  List<Student> students = new List<Student>();

// GET: api/Student

        [HttpGet(Name = "GetStudent")]

        public IEnumerable<Student> Get()

        {

            students.Add(new Student(){ id=1,name = "Estudiante a"});

            students.Add(new Student(){ id=2,name = "Estudiante 2"});

            return students;

        }

// GET: api/Student/5

        [HttpGet("{id}", Name = "Get")]

        public Student Get(int id)

        {

            Student student = new Student();



            student.id = id;

            student.name = "student " + id;



            return student;

        }

        [HttpPost]

        public IActionResult Post([FromBody] Student student)

        {

            if (student.id == 1)

            {

                return StatusCode(500);

            }

            else return StatusCode(201);

        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
