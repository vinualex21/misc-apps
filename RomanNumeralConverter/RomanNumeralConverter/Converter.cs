using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    public class Converter
    {
        public int ConvertFirstTenRomanNumeralToNumber(string numeral)
        {
            Dictionary<string, int> digits = new Dictionary<string, int>()
            { {"I",1}, {"II",2}, {"III",3}, {"IV",4}, {"V",5}, {"VI",6}, {"VII",7}, {"VIII",8}, {"IX",9}, {"X",10}};

            if (digits.ContainsKey(numeral??"null"))
                return digits[numeral];
            else
                throw new ArgumentException("Invalid numeral. Please enter a valid roman numeral.");
        }

        public int ConvertRomanNumeralToNumber(string numeral)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>()
            { { 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },{ 'C', 100 },{ 'D', 500 },{ 'M', 1000 }};

            if (!string.IsNullOrEmpty(numeral) && numeral.All(character => symbols.Keys.Contains(character)))
            {
                var currentChar = numeral[^1];
                int number = symbols[currentChar];
                foreach(var previousChar in numeral[..^1].Reverse())
                {
                    if (symbols[previousChar] >= symbols[currentChar])
                    {
                        number += symbols[previousChar];
                    }
                    //Only I,X,C can be used for subtraction
                    else if("IXC".Contains(previousChar))
                    {
                        number -= symbols[previousChar];
                    }
                    else
                    {
                        throw new ArgumentException("Invalid numeral. Please enter a valid roman numeral.");
                    }
                    currentChar = previousChar;
                }
                return number;
            }
            else
                throw new ArgumentException("Invalid numeral. Please enter a valid roman numeral.");

        }

        private void ValidateRomanNumeral()
    }
}
