using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Quad: Shape
    {
        public override float Result { get; set; }

        public int ChosenAttribute { get; set; }

        // rectangle
        protected float CalculateArea(float side1, float side2)
        {
            return side1 * side2;
        } 

        protected float CalculatePerimiter(float side1, float side2)
        {
            return (side1 + side2) * 2;
        }

        // square
        protected float CalculateArea(float side)
        {
            return (float)Math.Pow(side, 2);
        }

        protected float CalculatePerimiter(float side)
        {
            return side * 4;
        }

        protected override void AskForAttribute()
        {
            ChosenAttribute = InputManager.GetInputAndTypeValidate(
    "Please choose shape by specifying the choice with the corresponding integer:\n" +
    "0) Area\n" +
    "1) Perimiter\n" +
    "Q - to quit", ChosenAttribute, 1);

        }

        protected override void PrintResults(string shape, float result)
        {
            result = InputManager.RectifyDecimals(result);
            if (ChosenAttribute == 0)
            {
                Console.WriteLine($"The area of {shape} is {result}");
            }
            else if (ChosenAttribute == 1)
            {
                Console.WriteLine($"The perimiter of {shape} is {result}");
            }
        }

    }
}
