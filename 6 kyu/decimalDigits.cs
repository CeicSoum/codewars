using System;

public class DecTools {

    public static int Digits(ulong n) {
        int count = 0;
        ulong initial = n;

        if (n == 0) {
            count++;
        }

        while (n > 0) {
            n /= 10;
            count++;
        }

        Console.WriteLine(initial + " has " + count + " digits");
        return count;
    }
}
