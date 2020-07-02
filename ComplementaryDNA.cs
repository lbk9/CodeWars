using System.Text;

public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            var dnaString = dna.ToCharArray();
            var dnaBuilder = new StringBuilder();
            for(int i = 0; i < dnaString.Length; i++)
            {
              switch(dnaString[i].ToString())
              {
                case "A":
                  dnaBuilder.Append("T");
                  break;
                case "T":
                  dnaBuilder.Append("A");
                  break;
                case "G":
                  dnaBuilder.Append("C");
                  break;
                case "C":
                  dnaBuilder.Append("G");
                  break;
              }
            }
            
            return dnaBuilder.ToString();
        }
    }
