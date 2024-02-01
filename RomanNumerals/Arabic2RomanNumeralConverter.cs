using System.Runtime.InteropServices;

namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    private static Dictionary<int, string> conversions =
        new Dictionary<int, string>() {                        
            { 1000, "M"},
            { 900, "CM"},
            { 500, "D"},
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC"},
            { 50, "L"},
            { 40, "XL"},
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 4, "IV"},
            { 1, "I"},
        };

    public static string Convert(int arabic) {
        string roman = "";

        foreach(var keyValue in conversions)  {
            while (arabic >= keyValue.Key) {
                roman += keyValue.Value;
                arabic -= keyValue.Key;
            }
        }

        return roman;
    }
}
