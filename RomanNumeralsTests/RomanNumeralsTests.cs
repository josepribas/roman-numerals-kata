using FluentAssertions;
using RomanNumerals;

namespace RomanNumeralsTests;

public class Arabic2RomanNumeral
{
    [Theory]
    [InlineData("I", 1)]
    public void ShouldConvertCorrectly(string expected, int arabic)
    {
        Arabic2RomanNumeralConverter.Convert(arabic).Should().Be(expected);       
    }
}