using System;

public class Kata {

    public static bool Narcissistic(int value) {
        double count = 0;
        string digits = value.ToString();

        for (int i = 0; i < digits.Length; i++) {
            count += Math.Pow(digits[i] - '0', digits.Length);
        }
        
        Console.WriteLine(count);
        
        if (count == value) {
            return true;
        }

        else {
            return false;
        }

    }
}
