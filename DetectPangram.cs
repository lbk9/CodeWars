using System;
using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    return str.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
  }
}
