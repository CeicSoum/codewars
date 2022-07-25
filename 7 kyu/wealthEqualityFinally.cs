using System;
using System.Linq;

public class Kata {

  public static void RedistributeWealth(double[] wealth) {
    double sum = wealth.Sum();
    double redistribution = sum / wealth.Length;
    Array.Clear(wealth, 0, wealth.Length);
    Array.Fill(wealth, redistribution);
    
    if (wealth.Length > 1) {
    Console.WriteLine(wealth.Length + " persons" + ", sum total: " + sum + "$" + ", " + redistribution + "$ per person.");
    }
    
    else {
    Console.WriteLine(wealth.Length + " person" + ", sum total: " + sum + "$");
    }
    
  }
}
