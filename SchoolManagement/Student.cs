using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace SchoolManagement
{
    public class Student
    {
        public int studentId;//non static variable or instance varible 
        public string studentName;
        public string studentMailid;
        public double studentPercentage;
        public char PERCENTAGEGRADE;
        public static string schoolName;//static variable or class varible
        public static string schoolAddress;
        public void PrintStudentDetails()
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student name: " + studentName);
            Console.WriteLine("Student Mail Id:" + studentMailid);
            Console.WriteLine("Student Percentage: " + studentPercentage);
            Console.WriteLine("PERCENTAGE  GRADE: "+ PERCENTAGEGRADE);
            Console.WriteLine("School Name: " + Student.schoolName);
            Console.WriteLine("School Address: " + Student.schoolAddress);

            Console.WriteLine("----------------------------------------------------");

        }
        public void DisplayCertification()
        {
            Console.WriteLine("Student percentage: " + studentPercentage);
            if (studentPercentage > 90)
            {
                PERCENTAGEGRADE = 'A';
                Console.WriteLine("You have successfully passed with grade A");
            }
            else
            if (studentPercentage >= 80 && studentPercentage <=89)
            {
                PERCENTAGEGRADE = 'B';
                Console.WriteLine("You have successfully passed with grade B");

            }
            else
                if (studentPercentage >= 60 && studentPercentage <= 79)
            {
                PERCENTAGEGRADE = 'C';
                Console.WriteLine("You have successfully passed with grade D");
            }
            else
                if(studentPercentage < 60)
            {
                PERCENTAGEGRADE = 'D';
                Console.WriteLine("You have successfully passed with grade C");
            }
            else
            {
                PERCENTAGEGRADE = 'F';
            }
            



            }

    }
}
