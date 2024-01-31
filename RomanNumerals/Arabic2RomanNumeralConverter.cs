namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    private static Dictionary<int, string> conversions = 
        new Dictionary<int, string>() {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 5, "V" }
        };

    public static string Convert(int arabic) {      
        return conversions.GetValueOrDefault(arabic) ?? "";
    }
}
