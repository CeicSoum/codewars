using System.Numerics;
using System;

public class Kata {

 public static BigInteger[] PowersOfTwo(int n) {
   BigInteger[] powers = new BigInteger[n+1];
   
   for (int i = 0; i <= powers.Length-1; i++) {
    double num = Math.Pow(2,i);
    BigInteger convert = (BigInteger)Convert.ToDouble(num);
    powers[i]=convert;
   } 
   
   return powers;
  }
}
