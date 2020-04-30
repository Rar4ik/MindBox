using System;
using System.Collections.Generic;
using System.Globalization;

namespace Area.Handler
{
    public class InputHandler
    {
        public List<double> TransformInput(string input)
        {
            string[] trim = input.Split(new char[]{','});
            List<double> listOfDigits = new List<double>();
            foreach (var s in trim)
            {
                bool val = double.TryParse(s,NumberStyles.Any, CultureInfo.InvariantCulture, out double result);
                listOfDigits.Add(result);
                if (val == false)
                    throw new ArgumentException("Введено не число!");
            }
            return listOfDigits;
        }
    }
}
