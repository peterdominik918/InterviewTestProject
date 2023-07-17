using DEmployee.Helpers.Domain;
using DEmployee.DomainModelLayer.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEmployee.Helpers.Repository
{
    public interface IEmployeeRepository
    {
        Employee FindById(Guid id);


        void Add(Employee entity);

        void Remove(Employee entity);

        IEnumerable<Employee> GetAll();
    }
}
