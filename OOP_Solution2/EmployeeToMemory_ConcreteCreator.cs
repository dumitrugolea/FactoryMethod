using OOP_Solution2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Solution2
{
    class EmployeeToMemory_ConcreteCreator : IEmployeeSource_Creator
    {
        private List<IEmployee_Product> MemoryCache { get; } = new List<IEmployee_Product>(); 
        public void Add(IEmployee_Product employee)
        {
           MemoryCache.Add(employee);
            Console.WriteLine("S-a inscris in memorie");
            Console.WriteLine($"employee.Name: {employee.Name}");
        }

        public IEnumerable<IEmployee_Product> GetAll()
        {
            Console.WriteLine("S-a citit din memorie");
            return MemoryCache.AsEnumerable();
            
        }
    }
}
