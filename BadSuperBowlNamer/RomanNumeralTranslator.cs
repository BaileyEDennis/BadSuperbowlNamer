using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class RomanNumeralTranslator
    {
        public string NumberToNumeral(int numberToConvert)
        {
            //throw new NotImplementedException(); //for when you want to just have a non functioning method
            var result = numberToConvert switch
            {
                1 => "I",
                5 => "V",
                9 => "IX"
            };
            return result;
        }
    }
}
