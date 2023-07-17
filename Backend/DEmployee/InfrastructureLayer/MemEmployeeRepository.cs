using DEmployee.Helpers.Domain;
using DEmployee.Helpers.Repository;
using DEmployee.DomainModelLayer.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEmployee.InfrastructureLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected static List<Employee> entities = new List<Employee>();

        public Employee FindById(Guid id)
        {
            return entities.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Add(Employee entity)
        {
            entities.Add(entity);
        }

        public void Remove(Employee entity)
        {
            entities.Remove(entity);
        }

        public IEnumerable<Employee> GetAll()
        {
            return entities;
        }
    }
}
