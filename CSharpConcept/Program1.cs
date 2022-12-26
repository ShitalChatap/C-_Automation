using Math.AreaFormulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.CSharpConcept
{
    public class Program1
    {
        
        static void Main(string[] args)
        {
            int radius = 10;
            // Console.WriteLine("Hello");
            double res = Area.AreaOfcircle(10);
            Console.WriteLine(res);

            res = Area.AreaOfcircle(10);
            Console.WriteLine(res);
            //base=10.2,height=20.5
            double result = Area.AreaOfReactangle(10, 10);
            Console.WriteLine(result);

            double result1 = Area.AreaOfTriangle(10.2, 65);
            Console.WriteLine(result1);
            //Datatype.P1();
        }


    }
}
