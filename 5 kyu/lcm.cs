using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata {

  public static int Lcm(List<int> nums) {
    
    if (!nums.Any()) {
    return 1;
    }
    
    else if (nums.Contains(0)) {
    return 0;
    }
    
    else {
    
    for (int i = 0; i < nums.Count; i++) {
        Console.Write(nums[i] + " ");
    }
    
    int[] commons = nums.ToArray();
    int result = commons.Aggregate((S, val) => S * val / formula(S, val));
    return result;
    }
  }
  
  static int formula(int num1, int num2) {
            
    if (num2 == 0) {
       return num1;
    }
    
     else {
      return formula(num2, num1 % num2);
     }
    
    }
}
