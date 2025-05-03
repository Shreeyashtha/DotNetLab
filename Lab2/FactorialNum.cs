using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class FactorialNum
    {
        public void FactorialNumber()
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            FactorialNumm(a);
            Console.ReadKey();
        }

        static void FactorialNumm(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
