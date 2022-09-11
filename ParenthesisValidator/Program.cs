using System;

namespace ParenthesisValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // TODO unit tests
                Console.Clear();
                Console.Write("Enter a string to validate: ");
                var userInput = Console.ReadLine();
                var output = "";

                if (ValidateString(userInput))
                    output = "Valid, parentheses are balanced.";
                else
                    output = "Invalid, parentheses not balanced.";
                Console.WriteLine(output);

                Console.WriteLine("Press x to exit or any other key to enter another string.");
                if (Console.ReadKey().Key == ConsoleKey.X)
                    break;
            }

        }

        static bool ValidateString(string stringToValidate)
        {
            int counter = 0;
            for (int i = 0; i < stringToValidate.Length; i++)
            {
                if (stringToValidate[i] == '(')
                    counter++;

                if (stringToValidate[i] == ')')
                    counter--;
                
                // indicates a right paren without a preceding corresponding left paren
                if (counter < 0)
                    return false;
            }
            // indicates unclosed left parens
            if (counter > 0)
                return false;

            return true;
        }
    }
}
