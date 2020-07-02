using System.Text;
using System;

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    if(cc.Length < 4)
    {
      return cc;
    }
    else
    {
      var textArray = cc.ToCharArray();
      var maskBuilder = new StringBuilder();
      var visibleCharacters = cc.Substring(cc.Length-4);
      foreach(char c in textArray)
      {
        maskBuilder.Append("#");
      }
    
      var invisibleCharacters = maskBuilder.ToString();
      invisibleCharacters = invisibleCharacters.Remove(invisibleCharacters.Length-4);
      return String.Concat(invisibleCharacters, visibleCharacters);
    }

  }
}
