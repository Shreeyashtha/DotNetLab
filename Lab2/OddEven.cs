using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class OddEven
    {
        public void OddEvenNum()
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            OddEvenNum( a);
            Console.ReadKey(); 
        }
        static void OddEvenNum(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("a is even" + a);
            }
            else
            {
                Console.WriteLine("a is odd" + a);
            }
        }
    }
}
