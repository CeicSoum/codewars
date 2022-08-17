using System;
using System.Linq;
using System.Collections.Generic;

class MaxSumDigits {

    public static long[] MaxSumDig(long nmax, int maxsm) {
     List<long> nums = new List<long>();
     long num = 0;
      
     for (int i = 1000; i <= nmax; i++) {
      string digits = i.ToString();
      int count = 0; 
      int current = 0;

                for (int j = 0; j < digits.Length; j++) {
                    count += digits[j] - '0';
                }

                digits = count.ToString();
                current = count;
                count = 0;
       
         if ( current <=  maxsm) {
          nums.Add(i);
          num++;
         } 
         
     }
     
      long sum = Convert.ToInt64(nums.Sum());
      long found = sum / num;
      long closest = nums.Aggregate((x,y) => Math.Abs(x-found) < Math.Abs(y-found) ? x : y);
      long[] arr = {num, closest, sum};
      return arr;
      
    }
}
