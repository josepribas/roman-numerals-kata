using System.Runtime.InteropServices;

namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    private static Dictionary<int, string> conversions =
        new Dictionary<int, string>() {                        
            { 10, "X"},
            { 5, "V"},
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
