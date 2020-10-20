using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Solution2.Models
{
   
 
        public class Employee_ConcreteProduct : IEmployee_Product
        {

            public Employee_ConcreteProduct(string name, string location, string job, string project)
            {
                Name = name;
                Job = job;
                Location = location;
                Project = project;
            }

            public string Name { get; }
            public string Location { get; }
            public string Job { get; }
            public string Project { get; }


        }
    
}
