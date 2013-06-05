using System;
/*Write an if statement that examines two integer variables and exchanges 
 * their values if the first one is greater than the second one.
*/

class Program
{
    static void Main()
    {
        Console.Write("Insert value for A:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert value for B:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Number A:{0} B:{1}", a, b);
        if (a < b)
        {
            Console.WriteLine("{0}<{1}\nNo Exchange Needed", a, b);
        }
        if (a == b)
        {
            Console.WriteLine("They are equals: {0} = {1}", a, b);
        }
        if (a > b)
        {
            a ^= b ^ (b ^= a ^= b);
            Console.WriteLine("Number A is greater than B\nThats why A exchange whit B");
            Console.WriteLine("New A is: {0} and B is: {1}", a, b);
        }

    }
}
