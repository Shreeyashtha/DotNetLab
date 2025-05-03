using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class NaturalNum
    {
        public void  NaturalNumber() {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            NaturalNumber(n);
            Console.ReadKey();

        }

        static void NaturalNumber(int n)
        {
            int sum=0;
            for (int i = 0; i < n; i++)
            {
                sum += i;
            }
            Console.WriteLine("the sum of the natural number is :" +sum);


        }
    }
}
