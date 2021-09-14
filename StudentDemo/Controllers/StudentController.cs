using Microsoft.AspNetCore.Mvc;
using StudentDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new Student[] 
            {
               new Student() { rollNumber = 1, name ="Rashmi" ,iQ=1},
               new Student() { rollNumber = 2, name ="Shreya" ,iQ=2},
               new Student() { rollNumber = 3, name ="Surekha" ,iQ=3}
            };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return Get().FirstOrDefault(x => x.rollNumber == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            var student = this.Get(id);
            if(student != null)
            {
                student = value;
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
