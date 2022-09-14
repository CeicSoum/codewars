using System;
using System.Linq;
using System.Numerics;

public static class Kata {

   public static string sumStrings(string a, string b) {
   
      if (a == string.Empty) {
         a = "0";
      }
      
      if (b == string.Empty) {
         b = "0";
      }
      
      if (a.All(char.IsDigit) == true && b.All(char.IsDigit) == true) {
         BigInteger first = BigInteger.Parse(a);
         BigInteger second = BigInteger.Parse(b);
         BigInteger sum = first + second;
         Console.WriteLine(sum);
         return sum.ToString();
      }
      
      return "";
   }
}
