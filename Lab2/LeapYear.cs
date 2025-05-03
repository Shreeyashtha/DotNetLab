using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class LeapYear
    {
        public void LeapY()
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            LeapYr(n);
            Console.ReadKey();
        }

         static void LeapYr(int n)
        {
            if (n%4 == 0)
            {
                if (n%100 == 0)
                {
                    if (n%400 == 0)
                    {
                        Console.WriteLine("It is a leap Year" + n);
                    }
                    else {
                        Console.WriteLine("It is not a leap Year");
                    }
                }
                else
                {
                    Console.WriteLine("It is  a  leaP year");
                }
            }
            else
            {
                Console.WriteLine("It is not a leapYear");
            }

            }
            }

            
}
