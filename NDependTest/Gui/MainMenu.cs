using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    public class MainMenu
    {
        
        private EmployeeManagment _employeeManagment;
        private EmployeeList _employeList;

        public MainMenu(EmployeeManagment employeManagment, EmployeeList employeList)
        {
            _employeeManagment = employeManagment;
            _employeList = employeList;
        }


        public void ResolveOption(int selectedOption) 
        {
            if (selectedOption == 0) {
                printMenu();
            }
            else if (selectedOption == 1) {
                _employeeManagment.Add();
            }
            else if (selectedOption == 2) {
                Console.WriteLine("Type Name of employee to delete");
                var name = Console.ReadLine();
                _employeeManagment.Delete(name);
            }
            else if (selectedOption == 3) {
                _employeList.PrintList(_employeeManagment.EmployeeSource());
            }
        }

        private void printMenu()
        {
            Console.WriteLine("0. Print Menu");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Delete Employee");
            Console.WriteLine("3. Print Employee list");
        }
    }
}
