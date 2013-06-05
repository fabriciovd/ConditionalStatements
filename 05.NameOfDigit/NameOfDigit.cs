/*Write program that asks for a digit and depending on the input shows the name of that digit 
 * (in English) using a switch statement.
*/
using System;
using System.Threading;


class NameOfDigit
{
    static void Main()
    {
        Console.WriteLine("Insert number from 0 to 12\n\rOR press Ctrl+C to exit");
        while (true)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                default:
                    Console.WriteLine("Entred number is not valid");
                    break;
            }
        }
    }
}
