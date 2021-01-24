using Repository_LibrStandart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository_LibrStandart.Interfaces
{
   public interface IEmployeeRepos 
    {
        IEnumerable<Employee> GetEmployees(); //flera
        Employee GetEmployee(int id);  //hämta 1 baserad ID

    }
}
