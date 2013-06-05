/*We are given 5 integer numbers. Write a program that checks 
 * if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 => 1+1-2=0.
*/
using System;


class SubSetToZero
{
    static void Main()
    {
        Console.WriteLine("Insert Five Int values. Hit enter after each:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        // 1 variant with 5
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4}=0", a, b, c, d, e);
        }
        // 5 variants with 4
        else if (b + c + d + e == 0)//-a
        {
            Console.WriteLine("{0} + {1} + {2} + {3}=0", b, c, d, e);
        }
        else if (a + c + d + e == 0)//-b
        {
            Console.WriteLine("{0} + {1} + {2} + {3}=0", a, c, d, e);
        }
        else if (a + b + d + e == 0)//-c
        {
            Console.WriteLine("{0} + {1} + {2} + {3}=0", a, b, d, e);
        }
        else if (a + b + c + e == 0)//-d
        {
            Console.WriteLine("{0} + {1} + {2} + {3}=0", a, b, c, e);
        }
        else if (a + b + c + d == 0)//-e
        {
            Console.WriteLine("{0} + {1} + {2} + {3}=0", a, b, c, d);
        }
        // 10 variant whit 3
        else if (c + d + e == 0)//-a-b
        {
            Console.WriteLine("{0} + {1} + {2}=0", c, d, e);
        }
        else if (b + d + e == 0)//-a-c
        {
            Console.WriteLine("{0} + {1} + {2}=0", b, d, e);
        }
        else if (b + c + e == 0)//-a-d
        {
            Console.WriteLine("{0} + {1} + {2}=0", b, c, e);
        }
        else if (b + c + d == 0)//-a-e
        {
            Console.WriteLine("{0} + {1} + {2}=0", b, c, d);
        }
        else if (a + d + e == 0)//-b-c
        {
            Console.WriteLine("{0} + {1} + {2}=0", a, d, e);
        }
        else if (a + c + e == 0)//-b-d
        {
            Console.WriteLine("{0} + {1} + {2}=0", a, c, e);
        }
        else if (a + c + d == 0)//-b-e
        {
            Console.WriteLine("{0} + {1} + {2}=0", a, c, d);
        }
        else if (a + b + e == 0)//-c-d
        {
            Console.WriteLine("{0} + {1} + {2}=0", a, b, e);
        }
        else if (a + b + d == 0)//-c-e
        {
            Console.WriteLine("{0} + {1} + {2}=0", a, b, d);
        }
        else if (a + b + c == 0)//-d-e
        {
            Console.WriteLine("{0} + {1} + {2}=0", a, b, c);
        }
        // 10 variants whit 2
        else if (d + e == 0)//-a-b-c
        {
            Console.WriteLine("{0} + {1}=0", d, e);
        }
        else if (b + e == 0)//-a-c-d
        {
            Console.WriteLine("{0} + {1}=0", b, e);
        }
        else if (b + c == 0)//-a-d-e
        {
            Console.WriteLine("{0} + {1}=0", b, c);
        }
        else if (b + d == 0)//-a-c-e
        {
            Console.WriteLine("{0} + {1}=0", b, d);
        }
        else if (c + d == 0)//-a-b-e
        {
            Console.WriteLine("{0} + {1}=0", c, d);
        }
        else if (c + e == 0)//-a-b-d
        {
            Console.WriteLine("{0} + {1}=0", c, e);
        }
        else if (a + e == 0)//-b-c-d
        {
            Console.WriteLine("{0} + {1}=0", a, e);
        }
        else if (a + c == 0)//-b-d-e
        {
            Console.WriteLine("{0} + {1}=0", a, c);
        }
        else if (a + b == 0)//-c-d-e
        {
            Console.WriteLine("{0} + {1}=0", a, b);
        }
        else if (a + d == 0)//-b-c-e
        {
            Console.WriteLine("{0} + {1}=0", a, d);
        }
        // 5 variants whit 1
        else if (a == 0)//-b-c-d-e
        {
            Console.WriteLine("{0}=0", a);
        }
        else if (b == 0)//-a-c-d-e
        {
            Console.WriteLine("{0}=0", b);
        }
        else if (c == 0)//-a-b-d-e
        {
            Console.WriteLine("{0}=0", c);
        }
        else if (d == 0)//-a-b-c-e
        {
            Console.WriteLine("{0}=0", d);
        }
        else if (e == 0)//-a-b-c-d
        {
            Console.WriteLine("{0}=0", e);
        }
        else
        {
            Console.WriteLine("No Zero Sum");
        }
    }
}
