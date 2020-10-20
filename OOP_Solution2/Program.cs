using OOP_Solution2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Only for test
           // args = new string[] { "Memory", "Add" };
            //args = new string[] { "File", "Add" };
            //args = new string[] { "Database", "Add" };
            args = new string[] { "Database", "Get" };

            if (args.Length != 2)
            {
                Console.WriteLine("The application required 2 args....");
                return;
            }
          
            Enum.TryParse(args[0], out SourceType sourceType);
            Enum.TryParse(args[1], out OperationType operationType);

            ApplyFactory applyFactory = new ApplyFactory(sourceType);

            if (operationType == OperationType.Add)
            {
                var employeToAdd = new Employee_ConcreteProduct("name10", "location10", "job10", "project10");
                applyFactory.Add(employeToAdd);
               

            }
            else if (operationType == OperationType.Get)
            {
                IEnumerable<IEmployee_Product> employees = applyFactory.GetAll();
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Name);
                }
            }


        }
    }
}
