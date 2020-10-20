using OOP_Solution2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Solution2
{
    class ApplyFactory:IEmployeeSource_Creator
    {
        //private static Dictionary<SourceType, IEmployeeSource_Creator> factory;

        private readonly IEmployeeSource_Creator factory;

        public ApplyFactory(SourceType sourceType)
        {
            var dependency = new Dictionary<SourceType, IEmployeeSource_Creator>
            {
                [SourceType.Memory]  = new EmployeeToMemory_ConcreteCreator(),
                [SourceType.File]= new EmployeeToFile_ConcreteCreator(),
                [SourceType.Database]= new EmployeeToDatabase_ConcreteCreator()
            };

            if (dependency.ContainsKey(sourceType))
            {
                factory = dependency[sourceType];
            }
            else
            {
                throw new ArgumentNullException($"{sourceType} is not supported...");
            }

         
        }

        public void Add(IEmployee_Product employee)
        {
            factory.Add(employee);
        }

        public IEnumerable<IEmployee_Product> GetAll()
        {
            return factory.GetAll();
        }
    }
}
