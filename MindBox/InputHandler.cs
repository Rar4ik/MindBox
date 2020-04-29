using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MindBox
{
    public class InputHandler
    {
        public List<double> TransformInput(string input)
        {
            string[] trim = input.Split(new char[]{','});
            List<double> listOfDigits = new List<double>();
            foreach (var s in trim)
            {
                double.TryParse(s, out double result);
                listOfDigits.Add(result);
            }

            return listOfDigits;
        }
    }
}
