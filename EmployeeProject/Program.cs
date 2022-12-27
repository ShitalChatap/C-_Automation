using EmployeeProject;

namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args) 
        {
         Console.WriteLine("*********************EMPLOYEE DASHBORD*******************");
         Employee.companyName = "Maveric";
         Employee.companyLocation = "Chennai";

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();

            emp1.empId = 101;
            emp1.empName = "saul";
            emp1.empSalary = 9000;
            emp1.empPerformanceType = 'A';
            Employee.companyName = "Maveric Company";
            Console.WriteLine(emp1.empId);
            Console.WriteLine(emp1.empName);
            Console.WriteLine(emp1.empSalary);
            Console.WriteLine(emp1.empPerformanceType);
            emp2.empId = 102;
            emp2.empName = "Kim";
            emp2.empSalary = 12000.2;
            emp2.empPerformanceType = 'B';

            Employee.companyName = "Maveric Company";
            Console.WriteLine(emp2.empId);
            Console.WriteLine(emp2.empName);
            Console.WriteLine(emp2.empSalary);
            Console.WriteLine(emp2.empPerformanceType);

            emp3.empId = 103;
            emp3.empName = "Jack";
            emp3.empSalary = 6000.2;
            emp3.empPerformanceType = 'C';

            Employee.companyName = "Maveric Company";
            Console.WriteLine(emp3.empId);
            Console.WriteLine(emp3.empName);
            Console.WriteLine(emp3.empSalary);
            Console.WriteLine(emp3.empPerformanceType);


            emp1.PrintEmployeeDetail();
            emp2.PrintEmployeeDetail();
            emp3.PrintEmployeeDetail();
          //  emp3.PrintEmployeeDetail();







        }
    }
}
