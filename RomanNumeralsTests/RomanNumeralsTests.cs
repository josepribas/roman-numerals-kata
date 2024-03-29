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
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    [InlineData("XVIII", 18)]
    [InlineData("XL", 40)]
    [InlineData("L", 50)]
    [InlineData("LXXVI", 76)]
    [InlineData("XC", 90)]
    [InlineData("C", 100)]
    [InlineData("CLIV", 154)]
    [InlineData("CD", 400)]
    [InlineData("D", 500)]
    [InlineData("DCCCXLVI", 846)]
    [InlineData("DCCCLXXXIX", 889)]
    [InlineData("CM", 900)]
    [InlineData("M", 1000)]
    [InlineData("MDCLXXXVIII", 1688)]
    [InlineData("MCMXCIX", 1999)]
    [InlineData("MMVIII", 2008)]
    public void ShouldConvertCorrectly(string expected, int arabic)
    {
        Arabic2RomanNumeralConverter.Convert(arabic).Should().Be(expected);       
    }
}