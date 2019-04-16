using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingAnArray
{
    class Program
    {
        /// The main method. Generates a list of numbers, reverses that order, then prints the reversed array
        static void Main(string[] args)
        {
            int[] numbers = GenerateNums();//This will run the "GenerateNums()" method. If you put a value in these (), it will run the "GenerateNums(int amount)" method
            Reverse(numbers);
            ListNums(numbers);

            Console.ReadKey();
        }

        //This method generates an array of 10 numbers
        static int[] GenerateNums()
        {
            int[] numbers = new int[10];

            for (int range = 0; range < 10; range++)
            {
                // Because range starts w/ '0', we have to add '1' here
                numbers[range] = range + 1;
            }

            return numbers;
        }

        //This method generates a list of numbers starting with what is put in "GenerateNums()' above
        static int[] GenerateNums(int amount)
        {
            int[] numbers = new int[amount];

            for (int range = 0; range < amount; range++)
            {
                numbers[range] = range + 1;
            }

            return numbers;
        }

        //This method reverses the contents of the array that was passed in.

        static void Reverse(int[] numbers)
        {
            // Initialize one index at the start of the array, and another at the end of the array. The index of the last item in the
            // array is the length of the array - 1.
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
                // To swap two numbers, we need to copy one value out to a safe place ("temp") so that it doesn't get overwritten.
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                // Move on to the next pair.
                firstIndex++;
                secondIndex--;
            }
        }

        // This method lists the array of numbers you chose to run above

        static void ListNums(int[] numbers)
        {
            for (int range = 0; range < numbers.Length; range++)
            {
                Console.Write(numbers[range] + " ");
            }

            Console.WriteLine();
        }
    }
}
