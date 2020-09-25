using System;
using System.Collections.Generic;

namespace AlphabetDigitToLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load in the alphabet in corresponding indices - 1.
            char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            bool validInt;
            int validatedInt;

            Console.WriteLine("\nEnter your numbers, seperated by spaces, then press enter when complete:");

            // Take numbers as a string and seperate them.
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            // If number is valid (integer between 1 and 26), add it to integer array
            int[] intArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                validInt = int.TryParse(inputArray[i], out validatedInt);

                if (!validInt || validatedInt < 1 || validatedInt > 26)
                {
                    Console.WriteLine($"\n{inputArray[i]} is not a valid response.");
                }

                else
                {
                    intArray[i] = validatedInt;
                }
            }

            List<char> output = new List<char>();

            // Take characters from the alphabet matching the valid numbers and display them onscreen.
            foreach (int digit in intArray)
            {
                if (digit > 0)
                {
                    output.Add(alphabet[digit - 1]);
                }
            }

            Console.WriteLine($"\n\nYour inputted numbers translate to the following characters:\n\n");
            
            foreach (char c in output)
            {
                Console.Write(c);
            }

            Console.WriteLine($"\n\nPRESS ANY KEY TO EXIT.\n\n")



        }
    }
}
