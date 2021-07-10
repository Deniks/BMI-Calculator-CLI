using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    abstract class Shape: IShape
    {
        public abstract float Result { get; set; }

        protected abstract void AskForAttribute();

        protected abstract void PrintResults(string shape, float result);


    }
}
