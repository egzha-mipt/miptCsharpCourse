﻿using System;
/*
   Написать программу, в которой пользователь вводит в консоли 2 числа,
   а программа в ответ выдает результат 4 операций:
   Сложение, вычитание, умножение, деление.

   Каждую операцию реализовать через отдельную функцию.
   Числа от пользователя получать через console.readline()
 */

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static int SumNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }

        private static int SubstractionNumbers(int a, int b)
        {
            int c = a - b;
            return c;
        }

        private static int MultiplicationNumbers(int a, int b)
        {
            int c = a * b;
            return c;
        }

        private static int DivisionNumbers(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed");
                return 0;
            }
            else
            {
                int c = a / b;
                return c;
            }
        }
       
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] parts = numbers.Split(" ");
            int number1 = int.Parse(parts[0]);
            int number2 = int.Parse(parts[1]);
            
            int sumResult = SumNumbers(number1, number2);
            int subtractionResult = SubstractionNumbers(number1, number2);
            int multiplicationResult = MultiplicationNumbers(number1, number2);
            int divisionResult = DivisionNumbers(number1, number2);

            Console.WriteLine("Sum result: " + sumResult +
                              "\nSubtraction result: " + subtractionResult +
                              "\nMultiplication result: " + multiplicationResult +
                              "\nDivision result: " + divisionResult);
        }
    }
}