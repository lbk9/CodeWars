using System;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        // your code
        var printingCode = s.ToCharArray();
        var printErrors = 0;
        string[] lettersToMatch = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
        foreach(char l in printingCode)
        {
          var letterToCheck = l.ToString();
          if(!Array.Exists(lettersToMatch, element => element == letterToCheck))
          {
            printErrors++;
          }
        }
        
        return $"{printErrors}/{s.Length}";
    }
}
