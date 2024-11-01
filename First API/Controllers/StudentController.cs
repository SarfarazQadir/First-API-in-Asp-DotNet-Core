using First_API.Data;
using First_API.Migrations;
using First_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MyContext _myContext;

        public StudentController(MyContext myContext)
        {
            _myContext = myContext;
        }
        /*  [HttpPost]
          public async Task<ActionResult<Student>> Add(Student student)
          {
              await _myContext.Students.AddAsync(student);
              await _myContext.SaveChangesAsync();
              return Ok();
          }*/
        [HttpPost]
        public async Task<ActionResult<Employee>> Addemp(Employee emp)
        {
            await _myContext.tbl_emp.AddAsync(emp);
            await _myContext.SaveChangesAsync();
            return Ok(emp);
        }
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Fetch()
        {
            var data = await _myContext.tbl_emp.ToListAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> FetchOne(int id)
        {
           var data = await _myContext.tbl_emp.FindAsync(id);
            return Ok(data);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> Delete(int id)
        {
           var data = await _myContext.tbl_emp.FindAsync(id);
                _myContext.tbl_emp.Remove(data);
            await _myContext.SaveChangesAsync();
            return Ok("Delete Successfull");
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> Update(int id,Employee emp)
        {
            _myContext.Entry(emp).State = EntityState.Modified;
            await _myContext.SaveChangesAsync();
            return Ok(emp);
        }
    }
}
