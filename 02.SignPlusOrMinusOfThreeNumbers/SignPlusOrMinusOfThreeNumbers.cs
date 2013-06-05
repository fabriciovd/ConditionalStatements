/*Write a program that shows the sign (+ or -) of the product of 
 * three real numbers without calculating it. Use a sequence of if statements.
*/
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insert value for A: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Insert value for B: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Insert value for C: ");
        decimal c = decimal.Parse(Console.ReadLine());
        byte counter = 0;
        if (a > 0)
        {
            counter++;
        }
        else
        {
            counter--;
        }
        if (b > 0)
        {
            counter++;
        }
        else
        {
            counter--;
        }
        if (c > 0)
        {
            counter++;
        }
        else
        {
            counter--;
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
            if (counter == 3 || counter == 255)
            {
                Console.WriteLine("The product is +");
            }
            if (counter == 1 || counter == 253)
            {
                Console.WriteLine("The product is -");
            }
        }
        
    }
}
