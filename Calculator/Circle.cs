using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Circle : Shape
    {
        public int ChosenAttribute { get; set; }

        public override float Result { get; set; }


        private float radius;

        private float CalculateCircumference()
        {
            return 2 * (float)Math.PI * radius;
        }

        protected float CalculateArea()
        {
            return (float)Math.PI * (float)Math.Pow(radius, 2);
        }

        protected override void AskForAttribute()
        {
            ChosenAttribute = InputManager.GetInputAndTypeValidate(
    "Please choose shape by specifying the choice with the corresponding integer:\n" +
    "0) Area\n" +
    "1) Circumference\n" +
    "Q - to quit", ChosenAttribute, 1);


            // range check

        }

        private void GatherInput()
        {
            radius = InputManager.GetInputAndTypeValidate("Please Enter the radius:", radius);
            
            AskForAttribute();

            // other quad attributes
        }

        private void MakeCalculations()
        {
            if (ChosenAttribute == 0)
            {
                Result = CalculateArea();
            }
            if (ChosenAttribute == 1)
            {
                Result = CalculateCircumference();
            }
        }
        protected override void PrintResults(string shape, float result)
        {
            Result = InputManager.RectifyDecimals(result);

            if (ChosenAttribute == 0)
            {
                Console.WriteLine($"The area of {shape} is {result}");
            }
            else if (ChosenAttribute == 1)
            {
                Console.WriteLine($"The circumference of {shape} is {result}");
            }
        }

        public void Run()
        {
            GatherInput();
            MakeCalculations();
            PrintResults("circle", Result);
        }


    }
}
