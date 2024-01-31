namespace RomanNumerals;

public class Arabic2RomanNumeralConverter
{
    private static Dictionary<int, string> conversions = 
        new Dictionary<int, string>() {        
            { 1000, "M" },           
            { 500, "D" },           
            { 100, "C" },          
            { 50, "L" },          
            { 10, "X" }, 
            { 9, "IX" },              
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

    public static string Convert(int arabic) {  
        string roman = "";    
        foreach (var item in conversions)
        {
            while (arabic >= item.Key) 
            {
                roman += item.Value;
                arabic -= item.Key;
            }
        }
        return roman;
    }
}
