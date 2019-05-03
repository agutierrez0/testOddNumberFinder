using System;
using System.Collections;
using System.Collections.Generic;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Odd Number Finder by Angel Gutierrez
            // 5/1/2019


            // Prompts user to Input and shows example
            Console.WriteLine("Please Input numbers separated by a comma.");
            Console.WriteLine("Example: 1,2,3,4,5");

            // User Input
            Console.Write("Input: ");
            string userInput = Console.ReadLine();

            // Splits input up between commas
            string[] splitInput = userInput.Split(',');
            ArrayList inputList = new ArrayList();

            // Creates an int array from the string array 'splitInput'
            int[] userInputInt = Array.ConvertAll(splitInput, int.Parse);
            inputList.AddRange(userInputInt);

            // Searches for the odd numbers
            foreach (int index in userInputInt)
            {
                for (int i = 0; i < userInputInt.Length; i++)
                {
                    if (userInputInt[i] % 2 == 0)
                    {
                        inputList.Remove(userInputInt[i]);
                        userInputInt[i] = 0;
                    }


                }
            }

            // If there are no odd numbers, informs the user.
            if (inputList.Count == 0)
                Console.WriteLine("No odd number found in sequence.");

            // Searches for duplicates in the string
            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (userInputInt[j] == userInputInt[i])
                    {
                        inputList.Remove(userInputInt[i]);
                        j = i + 1;
                        break;
                    }
                }

            }
            // Outputs to user
            foreach (var index in inputList)
                Console.WriteLine(index);

            // Allows user to exit
            Console.WriteLine("Please type anything and press enter to exit the program.");
            Console.ReadLine();
        }
    }
}
