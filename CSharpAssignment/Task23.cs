using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class Task23
    {
       public static void p1()
        {
            int smith = 25;
            int John = 45;
            int henry = 65;
            if (smith > John || smith > henry)
            {
                if (John > henry)
                {
                    Console.WriteLine("henry is younger");
                }
                else
                {
                    Console.WriteLine("john is younger");
                }
            }
            else
            {
                Console.WriteLine("smith is younger");



            }
            if (smith == John && John == henry)
            {
                Console.WriteLine("Smith, John, henry are same age" + John);
            }
        }
    }

}
