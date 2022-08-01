using System;

public class Kata {

    public static string GetMiddle(string s) {

        if (s.Length % 2 == 0) {
            char c = s[(s.Length / 2) - 1];
            char c2 = s[(s.Length / 2)];
            Console.WriteLine(c.ToString() + c2.ToString());
            return c.ToString() + c2.ToString();
        }

        else {
            char c = s[((s.Length + 1) / 2) - 1];
            Console.WriteLine(c.ToString());
            return c.ToString();
        }

    }
}
