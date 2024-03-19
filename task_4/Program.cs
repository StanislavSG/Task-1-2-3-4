// Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.
using System;

class Program
{
    static void Main()
    {
        int N;
        while (!Int32.TryParse(Console.ReadLine(), out N))
        {
            Console.WriteLine("Введите целое число:");
        }

        string result = string.Join(",", N.ToString().Select(c => c - '0'));
        Console.WriteLine(result);
    }
}