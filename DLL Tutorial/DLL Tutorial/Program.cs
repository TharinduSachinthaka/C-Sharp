using System;
using TestDLL;

namespace TutorialDLL
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int y = int.Parse(Console.ReadLine());

            int resultDevision = MathSevice.Devide(x, y);
            Console.WriteLine("Result is "+resultDevision);

            Console.Read();
        }
    }
}