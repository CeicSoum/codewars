using System;

public class Suite {

    public static double going(int n) {

        int factorial = 1, total = 0, h = 1, i = 0;
        int first = 0;


        while (h <= n) {
            factorial = 1;

            for (i = 1; i <= h; i++) {
                factorial *= i;

                if (h == n && i == n) {
                    first = factorial;
                }

            }

            total += factorial;
            h++;
        }

        decimal u = (decimal)(1.000000 / first) * total;
        decimal trunc = Math.Truncate(u * 1000000) / 1000000;
        double result = (double)trunc;
        Console.WriteLine(result);
        return result;
    }
}
