using System;
public static class Kata {
  
   public static int CountCombinations(int money, int[] coins) {
     int[] recursion = new int[money + 1];
     recursion[0] = 1;

      if (money < 0 || coins.Length == 0 || coins == null) {
         return 0;
      }

      for (int i = 0; i < coins.Length; ++i) {
         for (int j = coins[i]; j <= money; ++j) {
            recursion[j] += recursion[j - coins[i]];
         }
      }
     
      return recursion[money];
   }
}
