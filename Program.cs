using System;

public class HelloWorld
{
    static void Main(String[] args)
    {
        System.Console.WriteLine("Hello C# World");
        System.Console.WriteLine("I am SHIBATU");

        System.Console.Write("\nEnter Name: ");
        string name = System.Console.ReadLine();

        System.Console.WriteLine("\nHello " + name);

        System.Console.Write("Enter a Number to Square: ");
        string input = System.Console.ReadLine();

        double number = Double.Parse(input);
        double solution = Math.Pow(number, 2);

        System.Console.WriteLine("\nThe Square of the Number is " + solution.ToString());

        string test = System.Console.ReadLine();
    }
}