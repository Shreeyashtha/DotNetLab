using Lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Enter a first number");
        //int input1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter a second number");
        //int input2 = Convert.ToInt32(Console.ReadLine());
        //Swap(input1, input2);
        //LargestNum obj = new LargestNum();
        //obj.largestCompare();
        //OddEven obj = new OddEven();
        //obj.OddEvenNum();
        //NaturalNum obj = new NaturalNum();
        //obj.NaturalNumber();
        //FactorialNum obj = new FactorialNum();
        //obj.FactorialNumber();
        //LeapYear obj = new LeapYear();
        //obj.LeapY();
        //PrimeNumber obj = new PrimeNumber();
        //obj.prime();
        //Arr obj = new Arr();
        //obj.ArraySum();
        NamePrint  obj = new NamePrint();
        obj.Print();

        Console.ReadKey();
    }
    static void Swap(int a, int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("The number after swap is" +a + "and" +b);

    }
}