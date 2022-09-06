using System;
using System.Linq;
using System.Collections.Generic;

public class Kata {

    public static long NextBiggerNumber(long n) {
      string digits = n.ToString();
      List<int> nums = new List<int>();
      List<int> numsReverse = new List<int>();
      long result = 0;
      long m = n;
      bool found = false;
      
       for (int i = 0; i < digits.Length; i++) {
        nums.Add(digits[i] - '0');
       }
      
        numsReverse = nums.ToList();
        numsReverse.Sort((a, b) => b.CompareTo(a));
        
         if ((n > - 1 && n < 10) || (nums.Distinct().Count() == 1) || nums.SequenceEqual(numsReverse)) {
          return -1;
         } 
      
          m += 1;

           while (found == false) {
            string compare = m.ToString();
            
             if (digits.All(x => compare.Contains(x) && digits.Count(a => a == x) == compare.Count(b => b == x)) == true) {
              result = m;
              found = true;
             }  

             m++;
           }  

        return result;
      
   }
 }
