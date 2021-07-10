using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Rectangle: Quad
    {
        private float side1;
        private float side2;

        private void GatherInput()
        {
            side1 = InputManager.GetInputAndTypeValidate("Please Enter the side 1:", side1);
            side2 = InputManager.GetInputAndTypeValidate("Please Enter the side 2:", side2);

            AskForAttribute();

            // other quad attributes
        }

        private void MakeCalculations()
        {
            if (ChosenAttribute == 0)
            {
                Result = CalculateArea(side1, side2);
            }
            if (ChosenAttribute == 1)
            {
                Result = CalculatePerimiter(side1, side2);
            }
        }
        public void Run()
        {
            GatherInput();
            MakeCalculations();
            PrintResults("square", Result);
        }
    }
}
