using NUnit.Framework;
using RomanNumeralConverter;
using FluentAssertions;
using System;

namespace RomanNumeralConverterTests
{
    public class ConverterTest
    {
        private Converter Converter;

        [SetUp]
        public void Setup()
        {
            Converter = new Converter();
        }

        [Test]
        public void FirstTen_Given_Valid_Roman_Numeral_Should_Return_Correct_Number()
        {
            Converter.ConvertFirstTenRomanNumeralToNumber("V").Should().Be(5);
            Converter.ConvertFirstTenRomanNumeralToNumber("X").Should().Be(10);
            Converter.ConvertFirstTenRomanNumeralToNumber("II").Should().Be(2);
            Converter.ConvertFirstTenRomanNumeralToNumber("IX").Should().Be(9);
        }

        [Test]
        public void FirstTen_Given_Invalid_Roman_Numeral_Should_Throw_Exception()
        {
            var ex = Assert.Throws<ArgumentException>(() => Converter.ConvertFirstTenRomanNumeralToNumber("G"));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertFirstTenRomanNumeralToNumber(null));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertFirstTenRomanNumeralToNumber(""));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertFirstTenRomanNumeralToNumber("x"));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertFirstTenRomanNumeralToNumber("XI"));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

        }

        [Test]
        public void AnyNumeral_Given_Valid_Roman_Numeral_Should_Return_Correct_Number()
        {
            Converter.ConvertRomanNumeralToNumber("V").Should().Be(5);
            Converter.ConvertRomanNumeralToNumber("X").Should().Be(10);
            Converter.ConvertRomanNumeralToNumber("VIII").Should().Be(8);
            Converter.ConvertRomanNumeralToNumber("IV").Should().Be(4);
            Converter.ConvertRomanNumeralToNumber("MCMLXXXVI").Should().Be(1986);
            Converter.ConvertRomanNumeralToNumber("DCCLXXXIV").Should().Be(784);
        }

        [Test]
        public void AnyNumeral_Given_Invalid_Roman_Numeral_Should_Throw_Exception()
        {
            var ex = Assert.Throws<ArgumentException>(() => Converter.ConvertRomanNumeralToNumber("GWER"));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertRomanNumeralToNumber(null));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertRomanNumeralToNumber(""));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertRomanNumeralToNumber("xv"));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

            ex = Assert.Throws<ArgumentException>(() => Converter.ConvertRomanNumeralToNumber("35"));
            Assert.That(ex.Message, Is.EqualTo("Invalid numeral. Please enter a valid roman numeral."));

        }


    }
}