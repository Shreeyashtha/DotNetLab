using OOP_Concepts;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperations mathOperation = new MathOperations();
        int addvalue = mathOperation.Add(4, 5);
        double addedvalue = mathOperation.Add(12.5, 11.3);
        int product = mathOperation.Multiply(5, 4);
        double decimal_product = mathOperation.Multiply(8.5, 10.5);
        Console.WriteLine($"The int type add value is {addvalue}");
        Console.WriteLine($"The doubleint type add value is {addedvalue}");
        Console.WriteLine($"The multiply type add value is {product}");
        Console.WriteLine($"The doublemultiply type add value is {decimal_product}");

        Console.ReadKey();
        Console.Clear();

        MathOperation inheritance = new MathOperation();
        double add = inheritance.Add(6.5, 5);
        double sub = inheritance.Subtract(7.5, 6);
        double mul = inheritance.Multiply(5.5, 4);
        double div = inheritance.Divide(25, 5.5);
        Console.WriteLine($"Add = {add}, Subtract = {sub}, Multiply = {mul}, Divide = {div}");

        Console.ReadKey();
        Console.Clear();

        Palindrome checkingPalindrome = new Palindrome();
        checkingPalindrome.checkPalindrome();

        Console.ReadKey();
        Console.Clear();

    }
}