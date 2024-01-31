using FluentAssertions;
using RomanNumerals;

namespace RomanNumeralsTests;

public class Arabic2RomanNumeral
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VI", 6)]
    [InlineData("VII", 7)]
    [InlineData("X", 10)]
    [InlineData("XVIII", 18)]
    [InlineData("L", 50)]
    [InlineData("LXXVI", 76)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    [InlineData("MDCLXXXVIII", 1688)]
    public void ShouldConvertCorrectly(string expected, int arabic)
    {
        Arabic2RomanNumeralConverter.Convert(arabic).Should().Be(expected);       
    }
}