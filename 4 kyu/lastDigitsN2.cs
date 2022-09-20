using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

public class GreenNumbers {
   
  public static BigInteger Get(int n) {
      
     if (n == 1) {
         return 1;
      }

      SortedSet < BigInteger > list = new SortedSet < BigInteger > ();
      int number = n + n / 5;
      int digit = 2;
      int count = 2;
      BigInteger num = 5;
      list.Add(num);
      BigInteger num2 = 6;
      list.Add(num2);

      while (count < number) {
         BigInteger numSquared = num * num;
         BigInteger powOfTen = BigInteger.Pow(10, digit);
         num = numSquared % powOfTen;
         num2 = powOfTen + 1 - num;
         list.Add(num);
         list.Add(num2);
         count += 2;
         digit++;
      }
    
      BigInteger[] bigIntegers = list.ToArray();
      Console.WriteLine(bigIntegers[n - 2]);
      return bigIntegers[n - 2];
   }

}
