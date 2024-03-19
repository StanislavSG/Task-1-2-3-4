// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число в диапазоне от 10 до 99:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            string numberString = number.ToString();
            int maxDigit = 0;

            foreach (char digit in numberString)
            {
                int digitValue = Convert.ToInt32(digit.ToString());
                if (digitValue > maxDigit)
                {
                    maxDigit = digitValue;
                }
            }

            Console.WriteLine("Наибольшая цифра числа: " + maxDigit);
        }
        else
        {
            Console.WriteLine("Введенное число не находится в диапазоне от 10 до 99.");
        }
    }
}