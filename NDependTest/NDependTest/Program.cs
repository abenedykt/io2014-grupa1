using Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDependTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var gui = new MainMenu(new EmployeeManagment(), new EmployeeList());
            int option = 0;
            while (option != 4)
            {
                gui.ResolveOption(option);
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
