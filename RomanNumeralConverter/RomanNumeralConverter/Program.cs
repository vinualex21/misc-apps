/***********************************************************************************
-------------------------
Roman Numeral Converter
_________________________

Given a roman numeral, the application converts it into the corresponding number.

***********************************************************************************/

using RomanNumeralConverter;

Converter converter = new Converter();

Console.Write("Please enter a roman numeral: ");
var numeral = Console.ReadLine();
var number = converter.ConvertRomanNumeralToNumber(numeral);
Console.WriteLine($"You converted the Roman Numeral {numeral} to the number {number}");
Console.ReadKey();

