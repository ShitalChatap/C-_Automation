using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int empId;//non static variable or instance varible 
        public string empName;
        public double empSalary;
        public char empPerformanceType;
        public static string companyName;//static variable or class varible
        public static string companyLocation;
        public double EmpSalary
        {
            get
            {
                //read
                return empSalary;
            }
            set
            {
                //Write
                {
                    if (value > 3000)
                    {
                        empSalary = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Salary . So default value remains!!!");

                    }
                }
            }
        }

        public void PrintEmployeeDetail()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee name: " + empName);
            Console.WriteLine("Employee Salary: ");
            Console.WriteLine("Employee Performance type: " + empPerformanceType);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("Company Location: " + Employee.companyLocation);
            Console.WriteLine("--------------------" + Employee.companyLocation);
        }
        //calculateBonus

        public void GetGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee Id: " + empId);
            if (empPerformanceType == 'A')
            {
                Console.WriteLine("25%");
                Console.WriteLine(empSalary + (empSalary * 25 / 100));
            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine("15%");
                Console.WriteLine(empSalary + (empSalary * 15 / 100));
            }
            else if (empPerformanceType == 'c')
            {
                Console.WriteLine("10%");
                Console.WriteLine(empSalary + (empSalary * 10 / 100));

            }
            else
            {
                Console.WriteLine("Not Eligible for Bonus!!!!");
            }
            Console.WriteLine("----------------------------------------------------------------");
        }

    }


}
