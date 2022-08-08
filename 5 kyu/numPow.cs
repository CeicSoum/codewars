using System;
using System.Linq;
using System.Collections.Generic;

public class PowerSumDig {

    public static long PowerSumDigTerm(int n) {

        List<long> nums = new List<long>();

        for (int i = 2; i < 100; i++) {

            for (int j = 2; j < 200; j++) {
                long val = (long)Math.Pow(i, j);
                long result = val;
                long sum = 0;

                while (val > 0) {
                    sum += val % 10;
                    val /= 10;
                }

                if (sum == i) {
                    nums.Add(result);
                }

            }

        }

        nums = nums.OrderBy(n => n).ToList();
        Console.WriteLine(nums[n - 1]);
        return nums[n - 1];
    }
}
