using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class ApplicationManager
    {
        public static int QuitApplication { get; set; }
        public static void AskForQuit()
        {
            QuitApplication = InputManager.GetInputAndTypeValidate("\nDo you wish to quit? (0 - no, 1 - yes)", QuitApplication, 1);
            if (QuitApplication == 1)
            {
                Quit();
            }
        }


        private static void Quit()
        {
            System.Environment.Exit(1);
        }
    }
}
