/*Write a program that, depending on the user's choice inputs int, 
 * double or string variable. If the variable is integer or double, 
 * increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. 
 * Use switch statement.
*/
using System;
using System.Threading;

class ThreeTypesWithCases
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        Console.WriteLine("Select one of \nInteger: 1\nDouble:  2\nString:  3");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Console.Write("Insert number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case 2:
                Console.Write("Insert number: ");
                double dnumber = double.Parse(Console.ReadLine());
                Console.WriteLine(dnumber + 1);
                break;
            case 3:
                Console.Write("Insert value for string: ");
                string str = Console.ReadLine();
                Console.WriteLine("{0}*", str);
                break;
            default:
                Console.WriteLine("Wrong input value");
                break;
        }
    }
}
