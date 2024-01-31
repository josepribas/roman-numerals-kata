namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    private static Dictionary<int, string> conversions = 
        new Dictionary<int, string>() {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 5, "V" },
            { 10, "X" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" },
        };

    public static string Convert(int arabic) {      
        return conversions.GetValueOrDefault(arabic) ?? "";
    }
}
