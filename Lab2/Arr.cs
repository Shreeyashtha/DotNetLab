using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Arr
    {
        public void ArraySum()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Sum of array elements: " + sum);
        }

    }
}
