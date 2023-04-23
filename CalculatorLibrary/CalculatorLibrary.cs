using System;
using System.IO;
using System.Diagnostics;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static float DoOperation(float a, float b, string op)
        {
            float res = float.NaN;
            switch (op)
            {
                case "a":
                    res = a + b;
                    break;

                case "s":
                    res = a - b;
                    break;

                case "d":
                    res = a / b;
                    break;

                case "m":
                    res = a * b;
                    break;
            }
            return res;
        }
    }
}