﻿namespace app 
{
    class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, let's learn C#!\n");
            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            
            
            Console.WriteLine("The sum of these numbers is: " + (number1+number2) +"\n");
        }
    }
}