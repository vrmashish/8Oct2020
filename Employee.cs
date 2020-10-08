using System;
using System.ComponentModel;
using System.Net;

class Employee1
{
    int Employid;
    string EmployName;
    string Department;
    string Manager;
    float Basicsalary;
    float netsal;
    float da;
    float hra, pf;
    int experience;
    static string companyName, companyAddress;
    public static int count = 0;

    public static void GetCompanyDetails()
    {
        Console.WriteLine("Enter Company Name");
        companyName = Console.ReadLine();
        Console.WriteLine("Enter Company Address");
        companyAddress = Console.ReadLine();


    }

    public Employee1() { }

    //public static void printcount()
    //{
    //    Console.WriteLine("The Number of Employees are {0}", count);
    //}


    public void getEmployedetail()
    {
        Console.WriteLine("Enter Employeeid");
        Employid = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter Employ Name");
        EmployName = Console.ReadLine();
        Console.WriteLine("Enter Department");
        Department = Console.ReadLine();
        Console.WriteLine("Enter Manager");
        Manager = Console.ReadLine();
        Console.WriteLine("Enter Basic Salary");
        Basicsalary = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Experience");
        experience = Convert.ToByte(Console.ReadLine());


    }
    public void show()
    {
        calculatenetsalary();
        Console.WriteLine("Employee id : {0}", Employid);
        Console.WriteLine("Employ Name : {0}", EmployName);
        Console.WriteLine("Department : {0}", Department);
        Console.WriteLine("Manager : {0}", Manager);
        Console.WriteLine("Basic Salary: {0}", Basicsalary);
        Console.WriteLine("Net Salary : {0}", netsal);
        Console.WriteLine("Experience : {0}", experience);
        count++;

    }


    void calculatenetsalary()
    {

        if (experience > 10)
        {
            da = (float)0.1 * Basicsalary;
            hra = (float)(0.085 * Basicsalary);
            pf = 6200;

        }
        else if (experience > 7 && experience < 10)
        {
            da = (float)(0.07 * Basicsalary);
            hra = (float)(0.065 * Basicsalary);
            pf = 4100;

        }

        else if (experience > 5 && experience < 7)
        {
            da = (float)(0.041 * Basicsalary);
            hra = (float)(0.038 * Basicsalary);
            pf = 1800;
        }
        else if (experience < 5)
        {
            da = (float)(0.019 * Basicsalary);
            hra = (float)(0.02 * Basicsalary);
            pf = 1200;
        }
        netsal = (Basicsalary + hra + da) - pf;

    }
    public Employee1(string EmployName, string Manager, string Department)
    {
        this.EmployName = EmployName;
        this.Manager = Manager;
        this.Department = Department;
        Console.WriteLine("Enter Employee ID: ");
        Employid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Experience: ");
        experience = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter Basic Salary: ");
        Basicsalary = Convert.ToInt32(Console.ReadLine());
    }

    public Employee1(int Employid, string EmployName, string Department)
    {
        this.Employid = Employid;
        this.EmployName = EmployName;
        this.Department = Department;
        Console.WriteLine("Enter Employee Experience: ");
        experience = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter Manager Name: ");
        Manager = Console.ReadLine();
        Console.WriteLine("Enter Basic Salary: ");
        Basicsalary = Convert.ToInt32(Console.ReadLine());
    }

    public Employee1(int Employid, string EmployName, int experience, string Department, float Basicsalary, string Manager  )
    {
        this.Employid = Employid;
        this.EmployName = EmployName;
        this.experience = experience;
        this.Department = Department;
        this.Basicsalary = Basicsalary;
        this.Manager = Manager;
    }
}

