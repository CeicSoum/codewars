using System;

public class Kata {

 public static long[] NumbersWithDigitInside(long x, long d) {
  long count = 0;
  long sum = 0;
  long product = 1;
  bool hasnumber = false;
  
   if (x > 0 && d >= 0 && d<=9) {
   
   for (int i = 0; i < x+1; i++) {
   
   if ( present(i, d) ) {
   count++;
   sum = sum + i;
   product = product * i;
   hasnumber = true;
   Console.WriteLine(i + "/ ");
   }
   
   }
   if (hasnumber == false) {
   count = 0;
   sum = 0;
   product = 0;
   }  
   
   }
   long[] result = new long[] { count, sum, product };
   Console.WriteLine(result[0] + " " + result[1] + " " + result[2]);
   return result;
   }
  
  public static bool present(int x, long d) {
   
   while (x > 0) {
    if (x % 10 == d)
    break;
    x = x / 10;
   }
   
   return (x > 0);
  }  
}
