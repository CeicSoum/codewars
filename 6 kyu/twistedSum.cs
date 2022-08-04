using System;

public class TwistedSum {

    public static long Solution(long n) {
        long count = 0;

        for (long i = 1; i < n + 1; i++) {
            
            if (i > 9) {
                string digits = i.ToString();

                for (int j = 0; j < digits.Length; j++) {
                    count += digits[j] - '0';
                    Console.WriteLine(digits[j] - '0');
                }

            }

            else {
                count += i;
                Console.WriteLine(i);
            }

        }
        Console.WriteLine(count);
        return count;
    }
}
