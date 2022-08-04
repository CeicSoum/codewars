using System;

public class Persist {
    
    public static int Persistence(long n) {
        string digits = n.ToString();
        int result = 1;
        int count = 0;
        
        if (n < 10) {
            Console.WriteLine("0");
            return 0;
        }

        else {

            while (digits.Length != 1) {

                for (int i = 0; i < digits.Length; i++) {
                    result *= digits[i] - '0';
                }

                digits = result.ToString();
                result = 1;
                count++;
            
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
