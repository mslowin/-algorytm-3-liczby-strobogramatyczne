using System;
using System.Collections.Generic;

namespace _algorytm_3__liczby_strobogramatyczne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("The app checks if the number is stroboramatic. Press q to exit.");
            Console.WriteLine();

            while (run)
            {
                string number = Console.ReadLine();
                if (number == "q") // if the input is "q"
                {
                    run = false;
                }
                else if (int.TryParse(number, out int value)) // if the input is an intiger
                {
                    if (CheckNumber(number))
                    {
                        Console.WriteLine("The number IS stroboramatic :D");
                        if (IsPrime(int.Parse(number)))
                        {
                            Console.WriteLine("and it IS prime :D");
                        }
                        else
                        {
                            Console.WriteLine("but it IS NOT prime :(");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The number IS NOT stroboramatic :(");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The input must be an intiger");
                }
                Console.WriteLine();
            }
        }

        private static bool CheckNumber(string number)
        {
            int counter = 0;
            List<char> digits = new List<char>();
            digits.AddRange(number);
            for (int i = 0; i < number.Length; i++)
            {
                int backwardsIndes = digits.Count - 1 - i; // index of the intiger from the back of a number
                // chceking if indexes going from the front and from the back are both equal to 8, 1, 0 or if they are alternately equal to 9 and 6 or 5 and 2.
                if ((digits[i] == '8' && digits[backwardsIndes] == '8') || (digits[i] == '1' && digits[backwardsIndes] == '1') ||
                    (digits[i] == '6' && digits[backwardsIndes] == '9') || (digits[i] == '9' && digits[backwardsIndes] == '6') ||
                    (digits[i] == '2' && digits[backwardsIndes] == '5') || (digits[i] == '5' && digits[backwardsIndes] == '2') ||
                    (digits[i] == '0' && digits[backwardsIndes] == '0'))
                {
                    counter++;
                }
            }
            if (counter == number.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPrime(int number)
        {
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}