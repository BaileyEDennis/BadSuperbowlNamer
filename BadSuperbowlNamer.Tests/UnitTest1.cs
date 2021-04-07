using BadSuperBowlNamer;
using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    //name the class for the things we are testing
    //an empty test will pass every time. This is bad.
    public class TranslateNumbersToRomanNumerals //translate_numbers_to_roman_numerals
    {
        [Fact] //this method is a test
        public void when_the_number_1_is_passed_I_should_be_returned() //must be public, and return nothing (void) and take no parameters.
        {
            //Arrange -> context creation
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();

            //Act -> the action being taken in a given context
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert -> my expectations as a result of the action
            Assert.Equal("I",result);            
        }

        [Fact]
        public void when_the_number_5_is_passed_V_should_be_returned()
        {
            //Arrange
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal("V", result);
        }
        
        [Fact]
        public void when_the_number_9_is_passed_IX_should_be_returned()
        {
            //Arrange
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "IX";

            //Act
            var Actualresult = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, Actualresult);
        }

    }
}
