using CSharpAssignment;
using Math.Volume.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Formulae
{
    public class Program
    {
        public static void Main(String[] args)
        {

            Task23.p1();
            double res = Volume1.VolumnOfCuboid(12, 12, 13);
            Console.WriteLine(res);
           
            Task2.p2();


        }
    }
}
