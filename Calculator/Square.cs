using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Square : Quad, IShape
    {
        public float Result { get; set; }

        private float side;

        private void GatherInput()
        {
            side = InputManager.GetInputAndTypeValidate("Please Enter the side:", side);
            AskForAttribute();

            // other quad attributes
        }

        private void MakeCalculations()
        {
            if (ChosenAttribute == 0)
            {
                Result = CalculateArea(side);
            }
            if (ChosenAttribute == 1)
            {
                Result = CalculatePerimiter(side);
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
