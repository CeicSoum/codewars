using System;

public class Kata {
    
    public static long DivisibleCount(long x, long y, long k) {
        long count = 0;
        
        for (long i = x; i < y; i++) {
            
            if (i % k == 0) {
                count++;
            }
        
        }
        Console.WriteLine(count);
        return count;
    }
}
