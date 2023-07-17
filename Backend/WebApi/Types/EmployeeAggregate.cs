using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Types
{
    /// <summary>
    /// Aggregate of Fire Reports corresponding to a certain
    ///  location name, in a certain county.
    /// </summary>    

    public class EmployeeAggregate : Entity
    {
        public string name { get; set; }
        public DateTime birthday { get; set; }

        public bool sex { get; set; }

        public string description { get; set; }

        public EmployeeAggregate(string name, DateTime birthday, bool sex, string description)
        {
            this.name = name;
            this.birthday = birthday;
            this.sex = sex;
            this.description = description;
        }

        /// <summary>
        /// To be used by the de-serializer
        /// </summary>
        public EmployeeAggregate() { }

    }
}
