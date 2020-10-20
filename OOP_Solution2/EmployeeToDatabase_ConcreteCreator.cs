using OOP_Solution2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Solution2
{
    class EmployeeToDatabase_ConcreteCreator : IEmployeeSource_Creator
    {
        public void Add(IEmployee_Product employee)
        {
            Console.WriteLine("Add to Database...");
        }

        public IEnumerable<IEmployee_Product> GetAll()
        {

            IEnumerable<IEmployee_Product> employees = new List<IEmployee_Product>();
            //{
            //  new Employee_ConcreteProduct("name2","location2","job2","project2")
            //};
            Console.WriteLine("S-a citit din baza de date...");
            return employees;
        }
    }
    //{
    //    private const string DbConnString = "connString";

    //    public void Add(Employee employee)
    //    {
    //        using (var conn = GetDbConnection())
    //        {
    //            conn.Execute(@"INSERT INTO SomeTable (Name, Location, Job, Project) Values (@Name, Location, Job, Project)",
    //            new
    //            {
    //                Name = employee.Name,
    //                Location = employee.Location,
    //                Job = employee.Job,
    //                Project = employee.Project
    //            });
    //        }
    //    }

    //    public IEnumerable<Employee> GetALL()
    //    {

    //        IEnumerable<Employee> employees;
    //        using (var conn = GetDbConnection())
    //        {
    //            employees = conn.Query<Employee>("SELECT * FROM SomeTable").AsEnumerable();
    //        }

    //        return employees;
    //    }

    //    private SqlConnection GetDbConnection()
    //    {
    //        return new SqlConnection(DbConnString);
    //    }
}

