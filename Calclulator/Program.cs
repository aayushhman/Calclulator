using System;

namespace Calclulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter second number");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Calculate calculate = new Calculate();

            Console.WriteLine("-----Calculatin Output-----");
            Console.WriteLine($"Addition : { calculate.Add(firstNum, secondNum)}");

            Console.WriteLine($"Subtraction : { calculate.Sub(firstNum, secondNum)}");

            Console.WriteLine($"Multiply : { calculate.Mul(firstNum, secondNum)}");

            Console.WriteLine($"Division : { calculate.Div(firstNum, secondNum)}");
        }
    }
}
