using System;
using System.Collections.Generic;

public class Kata {

   public static string Factorial(int n) {
      List <int> res = new List <int>();
      res.Add(1);
      int car = 0;
      string result = "";

      for (int i = 2; i <= n; i++) {
        
         for (int j = 0; j < res.Count; j++) {
            int temp = res[j] * i;
            res[j] = (temp + car) % 10;
            car = (temp + car) / 10;
         }

         while (car != 0) {
            res.Add(car % 10);
            car = car / 10;
         }

      }

      for (int k = res.Count - 1; k >= 0; k--) {
         result += res[k].ToString();
      }
     
      Console.WriteLine(result);
      return result;
   }
}
