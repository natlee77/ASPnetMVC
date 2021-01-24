using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Repository_LibrStandart.Models
{
   public  class Employee
    {
        public Employee() //tomt -altid
        {

        }
        public Employee(int id, string firstName, string lastName, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}
