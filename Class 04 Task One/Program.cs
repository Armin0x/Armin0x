using System;

namespace Class_4_Homework_1
{
    class Program
    {
        static void Substrings(string message)
        {

            int num = NumberChar(message.Length);
            string substringMessage = message.Substring(0, num);
            int newLength = substringMessage.Length;
            Console.WriteLine($"The new string is  {substringMessage.ToUpper()} and it has {newLength} characters");
        }
        static int NumberChar(int messageChar)
        {
            string inputNumber;
            int number;
            bool numberCheck;
            while (true)
            {
                Console.WriteLine("Enter the number of character.");
                inputNumber = Console.ReadLine();
                numberCheck = int.TryParse(inputNumber, out number);
                if (numberCheck)
                {
                    if (number > 1 && number < messageChar)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"Enter number between 1 and {messageChar}");
                    }
                }
                else
                {
                    Console.WriteLine($"Please input a valid number between 1 and {messageChar}");
                }
            }

        }
        static void Main(string[] args)
        {
            string message = "Hello from SEDC Codecademy v7.0";
            Substrings(message);
            Console.ReadLine();
        }
    }
}
