using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    //Your code goes here!
    var squareRoot = Math.Sqrt(n);
    var squareNumber = squareRoot - Math.Ceiling(squareRoot);
    bool result = squareNumber == 0 ? true : false;
    return result;
  }
}
