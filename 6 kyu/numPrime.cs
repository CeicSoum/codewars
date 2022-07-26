using System;

public static class Kata {

public static bool IsPrime(int n) {
 int formula = (int)Math.Floor(Math.Sqrt(n));
 Console.WriteLine(n);
   
 if (n == 2) {
 return true;
 }
   
 else if (n <= 1 || n % 2 == 0) {
 return false;
 }
   
 for (int i = 3; i <= formula; i+=2) {
   
   switch(n % i) {
   case 0:
   return false;
  }
  
 }
  
  return true;
  }
}
