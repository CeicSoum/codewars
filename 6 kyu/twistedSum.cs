using System;

public class TwistedSum {

    public static long Solution(long n) {
        long solution = 0;

        for (long i = 1; i <= n; i++) {
            long j = i;
            
            while (j != 0) {
                solution += j % 10;
                j /= 10;
            }
        }
        Console.Write(solution);
        return solution;
    }
}
