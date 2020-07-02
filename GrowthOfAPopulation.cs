using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
      var n = 0;
      while (p0 < p) 
      {
        n++;
        p0+=(int)(p0*percent/100)+aug;
      }
      if (p0 >= p)
      {
        return n;
      }
      return n;
    }
}
