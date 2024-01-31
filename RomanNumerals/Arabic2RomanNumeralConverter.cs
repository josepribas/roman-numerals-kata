namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    public static string Convert(int arabic) {
        if (arabic == 1)
            return "I";
        else 
            return "II";
    }
}
