using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEmployee.DomainModelLayer.Employees;

namespace DEmployee.ApplicationLayer.Employees
{
    public interface IEmployeeService
    {
        Employee Add(Employee employee);
        Employee Remove(Guid employeeId);
        Employee Update(Guid employeeId, string description);
        Employee Get(Guid employeeId);
        IEnumerable<Employee> GetAll();

    }
}
