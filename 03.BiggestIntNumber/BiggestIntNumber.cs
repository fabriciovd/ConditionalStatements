/*Write a program that finds the biggest of three integers using nested if statements.
*/
using System;

class BigestIntNumber
{
    static void Main()
    {
        Console.Write("Insert Value for A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert Value for B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Insert Value for B: ");
        int c = int.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Biggest is: {0}", a);
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("Biggest is: {0}", b);
            }
        }
        if (c > a)
        {
            if (c > b)
            {
                Console.WriteLine("Biggest is: {0}",c);
            }
        }
    }
}
