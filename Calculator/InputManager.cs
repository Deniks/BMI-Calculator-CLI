using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class InputManager: RangeValidation
    {
        public string RawInput { get; set; }
        public static string TypeError { get; }


        public static float GetInputAndTypeValidate(string message, float value)
        {
            Console.WriteLine(message);
            bool isValid = false;
            bool isNegative = false;
            do
            {
                isValid = float.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    Console.WriteLine(TypeError);
                }
                isNegative = CheckForNegativeValue(value);
                if (isNegative)
                {
                    Console.WriteLine("Please enter positive values.");
                    isValid = false;
                }
            } while (!isValid);
            return value;
        }

        public static int GetInputAndTypeValidate(string message, int value)
        {
            Console.WriteLine(message);
            bool isValid = true;
            string input;
            do
            {
                if (!isValid) // if the initial do fails it will display menu again.
                {
                    Console.WriteLine(message);
                }
                input = Console.ReadLine();
                isValid = int.TryParse(input, out value);
                if (!isValid)
                {
                    bool isQuitWanted = ListenForQuit(input);
                    Console.WriteLine(isQuitWanted);
                    if (isQuitWanted)
                    {

                        ApplicationManager.AskForQuit();
                    }
                    else
                    {
                        Console.WriteLine("Wrong, we expect you to input integer within the limit");
                    }
                }
            } while (!isValid);
            return value;
        }

        public static int GetInputAndTypeValidate(string message, int value, int limit)
        {
            Console.WriteLine(message);
            bool isValid = true;
            string input;
            do
            {
                if (!isValid) // if the initial do fails it will display menu again.
                {
                    Console.WriteLine(message);
                }

                input = Console.ReadLine();
                isValid = int.TryParse(input, out value);
                if (!isValid)
                {
                    bool isQuitWanted = ListenForQuit(input);
                    Console.WriteLine(isQuitWanted);
                    if (isQuitWanted)
                    {

                        ApplicationManager.AskForQuit();
                    }
                    else
                    {
                        Console.WriteLine("Wrong, we expect you to input integer within the limit");
                    }
                }
                else // final check, if the value is integer is valid going to be true and if the range check fails its false
                {
                    isValid = ValidateRange(value, 0, limit);
                }
            } while (!isValid);
            return value;
        }


        private static bool ListenForQuit(string value)
        {
            Console.WriteLine(value);
            if (value == "q")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static float RectifyDecimals(float value)
        {
            return (float)Math.Round(value, 2);
        }


        private static bool CheckForNegativeValue(float value)
        {

            if (value < 0)
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
