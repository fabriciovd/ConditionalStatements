/*Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 > "Zero"
	273 > "Two hundred seventy three"
	400 > "Four hundred"
	501 > "Five hundred and one"
	711 > "Seven hundred and eleven"
*/
using System;


class NumberPronunciation
{
    static void Main()
    {
        string[] to12 = { " ", "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve" };//[0 to 12]
        string[] to19 = { " ", "Eleven", "Twelve", "Thir", "Four", "Fif", "Six", "Seven", "Eigh", "Nine" };//[13 to 19]
        string[] to90 = { " ", " ", "Twen", "Thir", "Four", "Fif", "Six", "Seven", "Eigh", "Nine" };//[20 to 90]
        /*sorry for the blank spaces in the arry :) I lost myself in the calculations. It was much easier to add blank 
        spaces insetad to recorrect the code*/
        while (true)
        {
            Console.WriteLine("\nInsert Number: \n");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 12)
            {
                Console.WriteLine("{0}", to12.GetValue(number + 1));
            }
            else if (number >= 13 && number <= 19)
            {
                Console.WriteLine("{0}teen", to19.GetValue(number % 10));
            }
            else if (number >= 20 && number <= 99)
            {
                int des = number / 10;
                int ost = number % 10;
                if (ost != 0)
                {
                    number = number % 10;
                    Console.WriteLine("{0}ty {1}", to90.GetValue(des), to12.GetValue(ost + 1));
                }
                else
                {
                    Console.WriteLine("{0}ty", to90.GetValue(des));
                }
            }
            else if (number % 100 == 0)
            {
                Console.WriteLine("{0} Hundred", to12.GetValue(number / 100 + 1));
            }
            else
            {
                if (number % 100 >= 0 && number % 100 <= 12)
                {
                    Console.WriteLine("{0} Hundred {1}", to12.GetValue((number / 100) + 1), to12.GetValue(number % 100 + 1));
                }
                else if (number % 100 >= 13 && number % 100 <= 19)
                {
                    Console.WriteLine("{0} Hundred {1}teen", to12.GetValue((number / 100) + 1), to19.GetValue(number % 10));
                }
                else if (number % 100 >= 20 && number % 100 <= 99)
                {
                    Console.WriteLine("{0} Hundred {1}ty {2}", to12.GetValue((number / 100) + 1), to90.GetValue((number % 100 / 10)), to12.GetValue(number % 10 + 1));
                }
            }
        }
    }
}