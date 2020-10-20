using Newtonsoft.Json;
using OOP_Solution2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace OOP_Solution2
{
    class EmployeeToFile_ConcreteCreator : IEmployeeSource_Creator
    {
        //// private System.IO.FileStream FileToRead = System.IO.File.Create(@"C:\Users\dugolea\source\repos\OOP_Solution2\test.json");
            private const string FileToRead =@"test.json";

        public void Add(IEmployee_Product employee)
        {
            ////var fisier = System.IO.File.Create(@"C:\Users\dugolea\source\repos\OOP_Solution2\test.json");
            ////GetEmployeeFromFile();
            
            List<Employee_ConcreteProduct> employees = new List<Employee_ConcreteProduct>();
               
            employees.Add((Employee_ConcreteProduct)employee);
            System.IO.File.WriteAllText(FileToRead, JsonConvert.SerializeObject(employees));
        }

        public IEnumerable<IEmployee_Product> GetAll()
        {
            return GetEmployeeFromFile().AsEnumerable();
        }
       

        /// AICI VA TREBUI SA FAC CEVA............ 
        private List<Employee_ConcreteProduct> GetEmployeeFromFile()
        {
            List<Employee_ConcreteProduct> employees = JsonConvert.DeserializeObject<List<Employee_ConcreteProduct>>(System.IO.File.ReadAllText(FileToRead));
            return employees;
        }
    }
}
