using Microsoft.AspNetCore.Mvc;
using Repository_LibrStandart.Interfaces;
using Repository_LibrStandart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L2_depend_injection.Controllers
{
    public class EmployeesController : Controller
    {
        //_________________________
        //+repository=kalas ctor injection-implementera "IEmployeeRepos employeeRepos"
        //contract mellan de 2=>den ctor,när skapa den controller->kommer implementera metod->gör tillgänliga IEmployeeRepos
        //har 2 metod - men vet inte funktionalitet på den- enda vet interface"IEmployeeRepos"

        private readonly IEmployeeRepos _employeeRepos;  //_= privat leva bara här/associeras med Interfasce=vet inte funktionalit
        public EmployeesController(IEmployeeRepos employeeRepos)
        {
            _employeeRepos = employeeRepos;//" _employeeRepos "- det ska vi använda i resten av code

            //from services.AddSingleton()-StartUp.cs -->blir samma som :
            //_employeeRepos = new MockupEmployeeRepos(); //i mockup har funktionalitet GET...
            //det är hård knoten/i små project-ok
        }

        //__________________________
        //debug-> error message :
        //   InvalidOperationException: Unable to resolve service for type 
        //    'Repository_LibrStandart.Interfaces.IEmployeeRepos'
        //    while attempting to activate 'L2_depend_injection.Controllers.EmployeesController'.-->
        //måste specify funktionalitet-vad det sk användas för->vad är  "employeeRepos"->
        //->göra instance-pattern av det=skapa service i StartUp.cs


        public IActionResult Index()
        {
           //var1- ViewBag.employees;
           //var2:
            return View(_employeeRepos.GetEmployees());     //skapa view
            
        }
        public IActionResult Details(int id)
        {           
            return View(_employeeRepos.GetEmployee(id));     //skapa view
        }
        public IActionResult Delete(int id)
        {
            return View(_employeeRepos.GetEmployee(id));     //skapa view
        }
        //public IEnumerable<Employee> Index()
        //{
        //    //  return View();
        //    return _employeeRepos.GetEmployees();//skriva ut list
        //}
        //public string Index()
        //{
        //    //  return View();
        //    return _employeeRepos.GetEmployee(1).FirstName;//skriva ut med name//byta till "string Index()"
        //}
    }
}
