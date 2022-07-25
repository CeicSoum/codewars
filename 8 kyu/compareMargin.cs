using System;

public class Kata {
  public static int CloseCompare(double a, double b, double margin = 0) { 
   double max = Math.Max(a, b);
   double min = Math.Min(a, b);
   double compare = max - min;
    
    if (margin >= (compare)) {
     Console.WriteLine("a:" + a + " b:" + b + " margin:" + margin + " return: 0");
     return 0;
    }  
    
    else if (a < b) {
     Console.WriteLine("a:" + a + " b:" + b + " margin:" + margin + " return: -1");
     return -1;
    }
    
    else if (a > b) {
     Console.WriteLine("a:" + a + " b:" + b + " margin:" + margin + " return: 1");
     return 1;
    }
    
    return 0;
  }
}
