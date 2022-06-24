using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Sercanİyili.Homeworks.Week_1.Data;
using Sercanİyili.Homeworks.Week_1.DTOs;
using Sercanİyili.Homeworks.Week_1.Model;


namespace Sercanİyili.Homeworks.Week_1.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //singleton pattern'i api katmanına enjekte etmeye çalışıyorum.
        private readonly EmployeeData _employeeData;

        public EmployeeController()
        {
            _employeeData = EmployeeData.Singleton;
        }

        //private static List<Employee> Employees = EmployeeData.Employees;


        //api/Employees
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var employees = _employeeData.Employees;
                return Ok(employees);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        //api/Employees/1
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                var employee = _employeeData.Employees.FirstOrDefault(x => x.Id == id);
                if (employee is null)
                    return NotFound();
                else
                    return Ok(employee);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //api/Employees
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            if (employee is null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                _employeeData.Employees.Add(employee);
                return Created("~api/employees", employee);
            }
            else
                return StatusCode(500);
        }

        //api/Employees/1
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employeeData.Employees.FirstOrDefault(x => x.Id == id);

            if (employee is null)
                return NotFound();
            else
                _employeeData.Employees.Remove(employee);
            return NoContent();
        }

        //api/Employees/1
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id,[FromBody] Employee employee)
        {
            if (id != employee.Id)
                return BadRequest("Employee ID mismatch");

            var employeeUpdated = _employeeData.Employees.FirstOrDefault(x => x.Id == id);

            if (employeeUpdated is null)
                return NotFound();

            if (ModelState.IsValid)
            {
                employeeUpdated.Name = employee.Name;
                employeeUpdated.Surname = employee.Surname;
                employeeUpdated.City = employee.City;
                employeeUpdated.Age = employee.Age;
                employeeUpdated.Gender = employee.Gender;
                employeeUpdated.Department = employee.Department;

                return NoContent();
            }
            else
                return StatusCode(500);         
        }

        //api/Employees/list?name=ali
        [HttpGet]
        [Route("list")]
        public IActionResult GetEmployeeByName([FromQuery] string name)
        {
            try
            {
                var employee = _employeeData.Employees.Where(x => x.Name.ToLower() == name.ToLower()).ToList();
                if (employee.Count==0)
                    return NotFound();
                else
                    return Ok(employee);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //api/Employees/1
        [HttpPatch("{id}")]
        public IActionResult EmployeeCityUpdate(int id, [FromBody] JsonPatchDocument<Employee> employee)
        {           
            var employeeUpdated = _employeeData.Employees.FirstOrDefault(x => x.Id == id);
          
            if (employeeUpdated == null)
            {
                return NotFound();
            }

            employee.ApplyTo(employeeUpdated);

            return Ok(employeeUpdated);
        }

        //api/Employees/sort
        [HttpGet]
        [Route("sort")]
        public IActionResult GetEmployeesBySortedName()
        {
            var SortedList= _employeeData.Employees.OrderBy(x => x.Name).ToList();
            if (SortedList.Count == 0)
                return NotFound();
            else
                return Ok(SortedList);           
        }


    }
}
