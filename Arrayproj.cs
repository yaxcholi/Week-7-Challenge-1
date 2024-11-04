using System;

namespace MyArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = CreateAlphabetArray();
            PrintAlphabet(alphabet);
            PrintAlphabetInReverse(alphabet);
            ModifyAlphabetToUppercase(alphabet);

            int[] fibonacci = CreateFibonacciArray();
            FindMaximumInFibonacci(fibonacci);
            SortAndPrintFibonacci(fibonacci);
            SearchFibonacciForValue(fibonacci, 34);

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); // Waits for the user to press Enter
        }

        // Task 2: Create character array
        static char[] CreateAlphabetArray()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i); // 97 is the ASCII value for 'a'
            }
            return alphabet;
        }

        // Task 3: Print contents of the alphabet array
        static void PrintAlphabet(char[] alphabet)
        {
            Console.WriteLine("Alphabet:");
            foreach (char letter in alphabet)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine(); // For new line
        }

        // Task 4: Print data in reverse order
        static void PrintAlphabetInReverse(char[] alphabet)
        {
            Console.WriteLine("Alphabet in reverse:");
            for (int i = alphabet.Length - 1; i >= 0; i--)
            {
                Console.Write(alphabet[i] + " ");
            }
            Console.WriteLine(); // For new line
        }

        // Task 5: Modify data in array
        static void ModifyAlphabetToUppercase(char[] alphabet)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(65 + i); // 65 is the ASCII value for 'A'
            }
            Console.WriteLine("Uppercase Alphabet:");
            foreach (char letter in alphabet)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine(); // For new line
        }

        // Task 6: Create integer array
        static int[] CreateFibonacciArray()
        {
            return new int[] { 13, 1, 2, 3, 5, 8, 1, 34, 21, 55 };
        }

        // Task 7: Find maximum value in array
        static void FindMaximumInFibonacci(int[] fibonacci)
        {
            int maxValue = fibonacci[0];
            foreach (int number in fibonacci)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine($"Maximum value in Fibonacci array: {maxValue}");
        }

        // Task 8: Sort array in ascending order
        static void SortAndPrintFibonacci(int[] fibonacci)
        {
            Array.Sort(fibonacci);
            Console.WriteLine("Sorted Fibonacci array:");
            foreach (int number in fibonacci)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); // For new line
        }

        // Task 9: Search an array
        static void SearchFibonacciForValue(int[] fibonacci, int value)
        {
            int index = -1; // Default index to -1
            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (fibonacci[i] == value)
                {
                    index = i; // Store the index if found
                    break; // Exit the loop once found
                }
            }
            Console.WriteLine($"Index of {value} in Fibonacci array: {index}");
        }
    }
}
