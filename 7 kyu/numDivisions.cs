using System;

public class Kata {
  
  public static int Divisions(int n, int divisor) {
   int count = 0;
   
   if (n < divisor) { 
    Console.WriteLine("The number divisor is higher than n");
   }
   
    while (n >= divisor) { 
     Console.WriteLine(n+" / " + divisor);
     n = n / divisor;
     count++;
    }
    
    Console.WriteLine("resultat: " + count);
    return count++;
  }
}
