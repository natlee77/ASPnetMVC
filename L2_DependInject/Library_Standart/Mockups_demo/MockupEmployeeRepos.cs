using Repository_LibrStandart.Interfaces;
using Repository_LibrStandart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository_LibrStandart.Mockups_demo
{
    public class MockupEmployeeRepos : IEmployeeRepos

    {

        private List<Employee> _employees;
        //+ctor-populera list
        public MockupEmployeeRepos()
        {
            _employees = new List<Employee>
            {
                //hård code || sätta ctor -som gå mot DB -bätre i form controler-separat class -att använda på flera olika ställe
                new Employee(1, "Nata","Lisjö", "IT"),
                new Employee(2,"MAx","Lisjö", "Paython")
            };

        }
        public Employee GetEmployee(int id)
        {
            // throw new NotImplementedException()//fel meddelande - finns inga funktionalitet på den
            //return _employees.FirstOrDefault(e => e.Id == id);
            return _employees.FirstOrDefault(employee => employee.Id == id);

            //måste ha TRY-Catch -om det NUll
        }

        public IEnumerable<Employee> GetEmployees() 
        { //om jag vill hämta alla användare:
          //  return _employees;  //eftersom det är list
          //sortera: 
          //  return _employees.OrderBy;
          //  return _employees.OrderBy(e => e.FirstName).ToList();
            return _employees.OrderBy(e => e.Id).ToList();
        }
    }
}
