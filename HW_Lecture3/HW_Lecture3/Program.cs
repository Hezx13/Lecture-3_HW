using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW_Lecture3;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Find the factorial of number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        
        Console.WriteLine(Factorial(userInput));
        
        Console.Write("List fibonacci numbers: ");
        userInput = Convert.ToInt32(Console.ReadLine());
        
        List<int> fibonacci = Fibonacci(userInput);
        fibonacci.ForEach(Console.WriteLine);
    }

    public static int Factorial(int number)
    {
        IEnumerable<int> nums = Enumerable.Range(1, number);
        return nums.Aggregate((k, j) => k * j);
    }

    public static List<int> Fibonacci(int last)
    {
        List<int> fibonacciNumbers = new List<int>();
        Enumerable.Range(0, last).ToList()
            .ForEach(i => fibonacciNumbers.Add(i <= 1 ? 1: fibonacciNumbers[i-2] + fibonacciNumbers[i-1]));

        return fibonacciNumbers;
    }
}

