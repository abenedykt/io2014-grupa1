using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Manager : Employe
    {
        public string Department { get; private set; }
        private double _bonusSalary;

        public Manager(string firtsName, string lastName, double salary, string department, double bonusSalary)
            :base(firtsName, lastName, salary)
        {
            Department = department;
            _bonusSalary = bonusSalary;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + _bonusSalary;
        }
    }
}
