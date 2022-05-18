// 3 - Develop an algorithm that prints all odd numbers from 1 to 10.

using System;

class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("[All odd number from 1 to 10]\n");

        for (int num = 1; num < 11; num++)
        {
            if (num % 2 == 1) 
            {
                Console.WriteLine(num);
            }
        }
    }
}
