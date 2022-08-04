using System;

public class Number {
    
    public int DigitalRoot(long n) {
        string digits = n.ToString();
        int count = 0;
        int result = 0;

        if (n < 10) {
            result = (int)n;
            Console.WriteLine(result);
            return result;
        }

        else {
            
            while (digits.Length != 1) {

                for (int i = 0; i < digits.Length; i++) {
                    count += digits[i] - '0';
                }

                digits = count.ToString();
                count = 0;
            }
            Console.WriteLine(digits);
            return Int32.Parse(digits);
        }
    }
}
