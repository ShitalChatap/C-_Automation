using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Math.AreaFormulae
{
    public class Datatype
    {
        public static void P1(string[] args)
        {
            byte a = 200;//a is resister for sbyte -8 bits of memory
            short b = 2000;
            a = 100;
            int c  = 10;
            long d  = 99l;
            float e = 10.2f;
            double f = 10.2;
            f = c;//int to double -32 bit to 64 bit -implict conversion//no data loss
            //c = f;//double to int -64 bit to 32 bit - explicit conversion
            double x = 10.0;
            int y = (int)x;//double to int -64 bit to 32 bit -explicit conversion//data loss might happen
            

            int a1 = 10;
            int b1 = 20;
            int res = a1 + b1;
            Console.WriteLine(res);
            Console.WriteLine(a);
            Console.WriteLine(b);
           
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(x);
            Console.WriteLine(y);
            int radius = 10;
            //calculate area of circle
            double result = 3.14 * radius * radius;
           // double result = 22/7 * radius * radius;

            Console.WriteLine(result);
            // Console.WriteLine((double)22/7);
            string name = "Shital Chatap";

        }
    }
}
