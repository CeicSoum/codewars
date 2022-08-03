using System;

public class Kata {

    public static string Collatz(int n) {
        string fn = "";
        fn += n.ToString();
        fn += "->";

        while (n != 1) {

            if (n % 2 == 0) {
                n /= 2;
                fn += n.ToString();
            }

            else {
                n *= 3;
                n += 1;
                fn += n.ToString();
            }

            fn += "->";
        }
        fn = fn.Substring(0, fn.Length - 2);
        Console.WriteLine(fn);
        return fn;
    }
}
