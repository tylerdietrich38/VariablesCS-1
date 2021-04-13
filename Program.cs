using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            var numberOfCoffeeCups = 1;

            var fullName = "Tyler Dietrich";

            var today = "4/13/21";

            // Console.WriteLine("Coffee Cups equal" + numberOfCoffeeCups "Name is" + fullName "Today's date" + today");
            Console.WriteLine($"Cups of coffee - {numberOfCoffeeCups}. Name - {fullName}. Date - {today}");

            Console.WriteLine(" ");

            Console.Write("What is your name? ");

            Console.WriteLine(" ");

            var userName = Console.ReadLine();

            Console.WriteLine(" ");

            var greeting = $"It is nice to meet you, {userName} . Have a great day . ";
            Console.WriteLine(greeting);

            Console.WriteLine(" ");

            Console.WriteLine("Please input two numbers");

            var firstNumberString = Console.ReadLine();

            var secondNumberString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberString);

            var secondOperand = double.Parse(secondNumberString);

            var sum = firstOperand + secondOperand;
            Console.WriteLine($"{firstOperand} + {secondOperand} = {sum}");

            Console.WriteLine(" ");

            var difference = secondOperand - firstOperand;
            Console.WriteLine($"{secondOperand} - {firstOperand} = {difference}");

            Console.WriteLine(" ");

            var product = firstOperand * secondOperand;
            Console.WriteLine($"{firstOperand} * {secondOperand} = {product}");

            Console.WriteLine(" ");

            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"{firstOperand} / {secondOperand} = {quotient}");

            Console.WriteLine(" ");

            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"{firstOperand} % {secondOperand} = {remainder}");

            Console.WriteLine(" ");

            Console.WriteLine($"If you add {firstOperand} and {secondOperand} you get {sum} , If you subtract {secondOperand} from {firstOperand} you get {difference} , If you times {firstOperand} and {secondOperand} you get {product} , If you divide {firstOperand} and {secondOperand} you get {quotient} , If you find the remainder from {firstOperand} and {secondOperand} you get {remainder}");

        }
    }
}
