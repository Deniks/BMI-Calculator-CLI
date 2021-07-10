using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class RangeValidation
    {
        protected static bool ValidateRange(int value, int lowerBoundary, int upperBoundary)
        {
            bool isValid = false;

            if (value >= lowerBoundary && value <= upperBoundary)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"The value entered: {value} is outside the acceptable range.\n" +
                    $"The value must be between {lowerBoundary} and {upperBoundary}");
            }

            return isValid;
        }

        protected static bool ValidateRange(float value, float lowerBoundary, float upperBoundary)
        {
            bool isValid = false;

            if (value >= lowerBoundary && value <= upperBoundary)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"The value entered: {value} is outside the acceptable range.\n" +
                    $"The value must be between {lowerBoundary} and {upperBoundary}");
            }

            return isValid;
        }
    }
}
