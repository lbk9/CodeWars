using System.Collections;
using System.Collections.Generic;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    var listOfNumbers = new List<int>();
    var listOfZeroes = new List<int>();
    foreach(int i in arr)
    {
      if(i != 0)
      {
        listOfNumbers.Add(i);
      }
      else
      {
        listOfZeroes.Add(i);
      }
    }

    listOfNumbers.AddRange(listOfZeroes);
    return listOfNumbers.ToArray();
  }
}
