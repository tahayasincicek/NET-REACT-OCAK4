﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        int sum = 0;

        
        for (int i = 1; i <= number; i++)
        {
            sum += i;  
        }

        
        Console.WriteLine("The sum of numbers from 1 to " + number + " is: " + sum);
    }
}
