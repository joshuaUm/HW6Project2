/// Homework No. 6 Project No. 2
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 4 2021
/// 
/// Problem Statement : Create an array of integers, then reverse the contents of the integer array.
/// 
/// Plan:
/// 1. Generate integers using GenerateNumbers(), returning an array of 10 random integers
/// 2. Print numbers to show original array contents.
/// 3. Enter Reverse() to reverse the contents.
/// 4. In Reverse(), enter for loop to iterate through array.
/// 5. Reverse each integer by storing one of the values in a temp handle to safely swap the two numbers without losing data.
/// 6. End loop once all values are swapped, exit Reverse().
/// 7. Print reversed array.

using System;

namespace HW6Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            PrintNumbers(numbers);

            Console.WriteLine("-After Reverse-");

            Reverse(numbers);

            PrintNumbers(numbers);
        }



        static void Reverse(int[] numbers)
        {
            for (int i = 0, count = numbers.Length / 2; i < count; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = temp;
            }

        }

        static void PrintNumbers(int[] numbers)
        {
            String outputString = "";
            for (int i = 0, count = numbers.Length; i < count; i++)
            {
                outputString += numbers[i] + " ";
            }


            Console.WriteLine(outputString);


        }

        static int[] GenerateNumbers()
        {
            Random rand = new Random();
            int[] intArray = new int[10];
            for (int i = 0, count = intArray.Length; i < count; i++)
            {
                intArray[i] = rand.Next(1, 101);
            }

            return intArray;
        }


    }
}
