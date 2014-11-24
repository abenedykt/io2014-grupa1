using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    public class EmployeeManagment
    {
        private List<Employe> employes = new List<Employe>();

        public void Add()
        {
            Console.WriteLine("Select EmployeeType");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Type Name");
            var name = Console.ReadLine();
            Console.WriteLine("Type Surname");
            var surname = Console.ReadLine();
            Console.WriteLine("Set Salary");
            var salary = double.Parse(Console.ReadLine());
            if (t == 1) 
            {
                Console.WriteLine("Set Extra");
                var extaSal = double.Parse(Console.ReadLine());
                employes.Add(new Manager(name, surname, salary, "Managment", extaSal));
                return;
            }
            employes.Add(new Employe(name, surname, salary));
        }

        public List<Employe> EmployeeSource()
        {
            return employes;
        }

        public void Delete(string name)
        {
            var e = employes.Where(x => x.FirstName == name).FirstOrDefault();
            employes.Remove(e);
        }
    }
}
