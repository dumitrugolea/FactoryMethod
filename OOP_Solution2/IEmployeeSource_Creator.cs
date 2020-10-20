using OOP_Solution2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Solution2
{
    interface IEmployeeSource_Creator
    {
        void Add(IEmployee_Product employee);
        IEnumerable<IEmployee_Product> GetAll();
    }
}
