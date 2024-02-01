namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    public static string Convert(int arabic) {
        string roman = "";

        if (arabic >= 10) {
            roman += "X";
            arabic -= 10;
        } 

        if (arabic >= 5) {
            roman += "V";
            arabic -= 5;
        }            

        for (int i = 1; i<= arabic; i++) {
            roman += "I";               
        }

        return roman;
    }
}
