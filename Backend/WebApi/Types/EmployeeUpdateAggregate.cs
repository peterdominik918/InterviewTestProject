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

    public class EmployeeUpdateAggregate : Entity
    {

        public string description { get; set; }

        public EmployeeUpdateAggregate(string description)
        {
            this.description = description;
        }

        /// <summary>
        /// To be used by the de-serializer
        /// </summary>
        public EmployeeUpdateAggregate() { }

    }
}
