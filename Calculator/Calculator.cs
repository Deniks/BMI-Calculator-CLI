using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public int ChosenShape { get; set; }
        Square square = new Square();
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();
        public void Run()
        {
            do
            {
                ShowOptions();

                if (ChosenShape == 0)
                {
                    // calculate rectangle
                    rectangle.Run();
                }
                else if (ChosenShape == 1)
                {
                    // calculate square
                    square.Run();
                }
                else if (ChosenShape == 2)
                {
                    // calculate circle
                    circle.Run();
                }
                // add other shapes if needed

                ApplicationManager.AskForQuit();
            } while (ApplicationManager.QuitApplication == 0);
        }

        private void ShowOptions()
        {
            ChosenShape = InputManager.GetInputAndTypeValidate(
                "Please choose shape by specifying the choice with the corresponding integer:\n" +
                "0) Rectangle\n" +
                "1) Square\n" +
                "2) Circle\n" +
                "Q - to quit", ChosenShape, 2);
        }

    }
}
