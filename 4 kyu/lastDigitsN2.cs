using System;
using System.Numerics;
using System.Collections.Generic;

public class GreenNumbers {
  
   public static BigInteger Get(int n) {
       List<BigInteger> nums = new List<BigInteger>();
       BigInteger o;
       nums.Add(0);
       string green;
       string compare;
     
        for (int i = 1; i <= 5000; i++) {
          o = BigInteger.Pow(i, 2);
          compare = o.ToString();
          green = i.ToString();
          int length = green.Length;
          compare = compare.Substring(length-1);

           if (compare.Contains(green)) {
            nums.Add(i); 
          }     

        }
       
       return nums[n];
   }
}
