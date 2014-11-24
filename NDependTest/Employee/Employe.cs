using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employe
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private double _salary;

        public Employe(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            _salary = salary;
        }

        public virtual double GetSalary()
        {
            return _salary;
        }
        
    }
}
