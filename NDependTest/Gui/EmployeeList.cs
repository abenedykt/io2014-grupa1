using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    public class EmployeeList
    {
        public void PrintList(List<Employe> source)
        {
            foreach (var item in source)
            {
                if (item is Manager) 
                {
                    var tmp = item as Manager;
                    Console.WriteLine("{0} {1} {2} {3}", tmp.FirstName, tmp.LastName, tmp.Department, tmp.GetSalary()); continue;
                }
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.GetSalary());
            }
        }
    }
}
