/*Write a program that applies bonus scores to given scores in the range [1..9]. 
 * The program reads a digit as an input. If the digit is between 1 and 3, 
 * the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
 * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, 
 * the program must report an error.
		Use a switch statement and at the end print the calculated new value in the console.
*/
using System;


class BonusScores
{
    static void Main()
    {


        int number = -1;
        bool rep = true;
        while (rep == true)
        {
            Console.WriteLine("Insert score from 1 to 9");
            string score = Console.ReadLine();
            try
            {
                number = Convert.ToInt32(score);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException! Input value is not from the sequence [1...9]");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number cannot fit in an Int32. ");
            }
            finally
            {
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3: number *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        number *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        number *= 1000;
                        break;
                    default:
                        Console.WriteLine("Reporting, Error! Value must be, defferent than 0/diffrent than characters"); ;
                        break;
                }
            }
            Console.WriteLine(number);
            Console.WriteLine("Continue: Y/N");
            string cont = Console.ReadLine();

            if (cont == "y" || cont == "y")
            {
                rep = true;
            }
            else
            {
                rep = false;
            }
        }
    }
}
