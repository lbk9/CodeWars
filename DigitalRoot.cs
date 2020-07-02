using System;
using System.Linq;

public class Number
{
  public int DigitalRoot(long n)
  {
        while (n > 9)
        {
            n = n.ToString().ToCharArray().Sum(x => x - '0');
        }
        
        return (int)n;
  }
}
