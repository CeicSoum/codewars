using System;
using System.Linq;

public class Kata {

  public static int ExpressionsMatter(int a, int b, int c) {
  
   if ((a >= 1 && a <= 10) && (b >= 1 && b <= 10) && (c >= 1 && c <= 10)) {
    int firstEq = a * (b + c);
    int secondEq = a * b * c;
    int thirdEq = a + b * c;
    int fourthEq = (a + b) * c;
    int fifthEq = a + b + c;
    
    Console.WriteLine("-");  
    Console.WriteLine(firstEq);
    Console.WriteLine(secondEq);
    Console.WriteLine(thirdEq);
    Console.WriteLine(fourthEq);
    Console.WriteLine(fifthEq);
    
    int[] expArray = { firstEq, secondEq, thirdEq, fourthEq, fifthEq };
    int maximum = expArray.Max();
    return maximum;
    }
    
    else {
     return 0;
    }
   }
}
