using System;
using System.Collections.Generic;

public class IntTriangles {

    public static int GiveTriang(int per) {
        int result = 0;

        for (int a = 1; a < per - 1; a++) {

            for (int b = a; b < per - 1; b++) {
              
                double c = Math.Sqrt(a * a + a * b + b * b);

                if (a + b + c <= per && a + b > c && b + c > a && c + a > b && c % 1 == 0) {
                    result++;
                }

            }

        }

        Console.WriteLine(result);
        return result;
    }
}
