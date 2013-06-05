/*Write a program that finds the greatest of given 5 variables.
*/
using System;
using System.Linq;


class GreatestOfGiven5Nums
{
    static void Main()
    {
        int[] arr = new int[5];         //Using 1 dimentional arry of five elements
        for (int x = 0; x < 5; x++)     //Using Loop to enter the data in the position of the arry
        {
            Console.Write("Number {0}: ", x + 1);
            arr[x] = int.Parse(Console.ReadLine());
        }
        int greatestNumber = arr.Max();//Using .Max method to extract biggest number form the arry
        Console.WriteLine("The Greatest number is: {0}", greatestNumber);
    }
}