using SchoolManagement;

namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************STUDENT DASHBORD*******************");
            Student.schoolName = "Global school";
            Student.schoolAddress = "chennai";

            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student();

            std1.studentId = 1001;
            std1.studentName = "jack";
            std1.studentMailid = "jack@gmail.com";
            std1.studentPercentage = 45.2;
            std1.PERCENTAGEGRADE = 'C';
            Student.schoolName = "Global school";
            Student.schoolAddress = "chennai";


            Console.WriteLine(std1.studentId);
            Console.WriteLine(std1.studentName);
            Console.WriteLine(std1.studentMailid);
            Console.WriteLine(std1.studentPercentage);
            Console.WriteLine(std1.PERCENTAGEGRADE);


            std2.studentId = 1002;
            std2.studentName = "peter";
            std2.studentMailid = "peter@gmail.com";
            std2.studentPercentage = 85.2;
            std2.PERCENTAGEGRADE = 'B';
            Student.schoolName = "Global school";
            Student.schoolAddress = "chennai";



            Console.WriteLine(std2.studentId);
            Console.WriteLine(std2.studentName);
            Console.WriteLine(std2.studentMailid);
            Console.WriteLine(std2.studentPercentage);
            Console.WriteLine(std2.PERCENTAGEGRADE);

            std3.studentId = 1003;
            std3.studentName = "mark";
            std3.studentMailid = "mark@gmail.com";
            std3.studentPercentage = 56.5;
            std3.PERCENTAGEGRADE = 'C';
            Student.schoolName = "Global school";
            Student.schoolAddress = "chennai";

            Console.WriteLine(std3.studentId);
            Console.WriteLine(std3.studentName);
            Console.WriteLine(std3.studentMailid);
            Console.WriteLine(std3.studentPercentage);
            Console.WriteLine(std3.PERCENTAGEGRADE);


            std1.PrintStudentDetails();
            std2.PrintStudentDetails();
            std3.PrintStudentDetails();
            //  emp3.PrintEmployeeDetail();

            std1.DisplayCertification();
            std2.DisplayCertification();
            std3.DisplayCertification();

        }
    }
}