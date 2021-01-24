using Repository_LibrStandart.Models;
using System;
using System.Collections.Generic;
using System.Text;



namespace Repository_LibrStandart.Interfaces
{
    public class EmployeeRepos : IEmployeeRepos
    {
        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}