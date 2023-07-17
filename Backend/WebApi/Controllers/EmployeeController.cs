using Microsoft.AspNetCore.Mvc;
using DEmployee.ApplicationLayer.Employees;
using DEmployee.DomainModelLayer.Employees;
using FluentValidation;
using FluentValidation.Results;
using WebApi.Types;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService employeeService;

    public EmployeeController(IEmployeeService _employeeService)
    {
        employeeService = _employeeService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Employee>> GetAll()
    {
        return Ok(employeeService.GetAll());
    }

    [HttpPost]
    public ActionResult<Employee> Add([FromBody] EmployeeAggregate employee)
    {
        try
        {
            EmployeeValidator validator = new EmployeeValidator();

            ValidationResult result = validator.Validate(employee);

            if (result.IsValid)
            {

                Employee newEmployee = employeeService.Add(Employee.Create(employee.name, employee.birthday, employee.description, employee.sex));
                return Ok(newEmployee);
            }
            else
            {
                throw new Exception("Validation Error");
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> Update(Guid id)
    {
        try
        {
            Employee employee = employeeService.Get(id);
            return Ok(employee);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<Employee> Update(Guid id, [FromBody] EmployeeUpdateAggregate description)
    {
        try
        {
            Employee newEmployee = employeeService.Update(id, description.description);
            return Ok(newEmployee);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<Employee> Delete(Guid id)
    {
        try
        {
            return Ok(employeeService.Remove(id));
        }
        catch
        {
            return StatusCode(500);
        }
    }
}
