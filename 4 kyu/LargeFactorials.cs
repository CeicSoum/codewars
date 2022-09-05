using System;

public class Kata {
  
  public static string Factorial(int n) {
    ulong m = Convert.ToUInt64(n);
    ulong result = 1;
    
    while ( m != 1) {
    result = result * m;
    m -= 1;
    }
    
    Console.WriteLine(result);
    return result.ToString();
  }
}
