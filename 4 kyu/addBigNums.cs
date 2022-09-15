using System;
using System.Linq;
using System.Numerics;

public class Kata {

   public static string Add(string a, string b) {
      BigInteger sum = BigInteger.Parse(a) + BigInteger.Parse(b);
      Console.WriteLine(sum);
      return sum.ToString();
   }
   
}
