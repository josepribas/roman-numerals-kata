namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    public static string Convert(int arabic) {
        string roman = "";

        if (arabic == 5)
            return "V";

        for (int i = 1; i<= arabic; i++) {
            roman += "I";               
        }

        return roman;
    }
}
