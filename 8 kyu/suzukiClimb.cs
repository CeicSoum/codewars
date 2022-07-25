using System;
using System.Linq;

public class Kata {

 public static long StairsIn20(int[][] stairs) {
  long total = stairs[0].Sum() + stairs[1].Sum() + stairs[2].Sum() + stairs[3].Sum() + stairs[4].Sum() + stairs[5].Sum() + stairs[6].Sum();
  long formula = total * 20;
  return formula;
 }
  
}
