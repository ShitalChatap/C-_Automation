using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Math.AreaFormulae
{
    public class Area
    {
        //access modifier static returntype MethodName(arguments)
        public static double AreaOfcircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }
        //create a static method for AreaOfrectangle()
        public static double AreaOfReactangle(double length, double width)
        {
            return length * width;

        }
        //create a static method for AreaOfTriangle()
        public static double AreaOfTriangle(double base1,double height)
        {
            return (base1 * height)/2;  
        }


        //create a static method for AreaOfTrapezium()
        public static double AreaOfTrapezium(double base1,double base2,double height)
        {
                    return((base1 + base2)/2.0) * height; 
        }
        
    }
}
