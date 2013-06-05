/*Sort 3 real values in descending order using nested if statements.
*/
using System;


class DescendingValues
{
    static void Main()
    {
        Console.Write("Insert value for A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert value for B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Insert value for C: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Descending order is:");
        if (a > b && b > c && a > c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else if (a > b && a > c && c > b)
        {
            Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        else if (a < b && b > c && a > c)
        {
            Console.WriteLine("{0} {1} {2}", b, a, c);
        }
        else if (a < b && b > c && c > a)
        {
            Console.WriteLine("{0} {1} {2}", b, c, a);
        }
        else if (a > b && b < c && c > a)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
        }
        else if (a < b && b < c && c > a)
        {
            Console.WriteLine("{0} {1} {2}", c, b, a);
        }
    }
}