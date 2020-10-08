using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee1.GetCompanyDetails();
            string choice = "y";
            static employCount = 
            while (choice == y)
            {

                Employee1 employ1 = new Employee1();
                employ1.show();
                Employee1 employ2 = new Employee1(1, "Ajay", "HR");
                employ2.show();
                Employee1 employ3 = new Employee1("Ashish", "Ram", "HR");
                employ3.show();
                Employee1 employ4 = new Employee1(1, "Aman", 20, "Software", 25000, "Hemant");
                employ4.show();
                
            }
        }
    }
}