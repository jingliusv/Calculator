using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCal
{
    class InputConverter
    {
        public double ConvertInputToNum(string input)
        {
            double convertedNumber;
            if(!double.TryParse(input.Trim(), out convertedNumber))
                throw new ArgumentException("Mata in ett nummer.");
            return convertedNumber;
        }
    }
}
