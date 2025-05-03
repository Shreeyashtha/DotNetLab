using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class LargestNum
    {
        public void largestCompare()
        {
            Console.WriteLine("enter a number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 & num1 > num3)
            {
                Console.WriteLine("num1 is largest" + num1);
            }
            else if (num2 > num3 & num2 > num1)
            {
                Console.WriteLine("num2 is largest" + num2);
            }
            else
            {
                Console.WriteLine("num3 is largest" + num3);

            }
        }
    }
}
