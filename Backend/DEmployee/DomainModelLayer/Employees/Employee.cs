using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using DEmployee.Helpers.Domain;

namespace DEmployee.DomainModelLayer.Employees
{
    public class Employee : IAggregateRoot
    {
        public virtual Guid Id { get; protected set; }

        public virtual string Name { get; protected set; }
        public virtual DateTime Birthday { get; protected set; }
        public virtual bool Sex { get; protected set; }
        public virtual string Description { get; protected set; }


        public static Employee Create(string name, DateTime birthday, string description, bool sex)
        {
            Employee employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Birthday = birthday,
                Description = description,
                Sex = sex
            };

            return employee;
        }

        public virtual void SetDescription(string description)
        {
            this.Description = description;
        }
    }
}
