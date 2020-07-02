using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int numberOfX = input.ToLower().Count(s => s == 'x');
    int numberOfO = input.ToLower().Count(s => s == 'o');
    return numberOfX - numberOfO == 0 ? true : false;
  }
}
