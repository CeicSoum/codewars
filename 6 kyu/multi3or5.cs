using System;

public static class Kata {
    
    public static int Solution(int value) {
        int count = 0;

        if (value < 0) {
            return 0;
        }

        else {
            
            for (int i = 0; i < value; i++) {
                
                if (i % 3 == 0 || i % 5 == 0) {
                    count += i;
                }

            }
            Console.WriteLine(count);
            return count;
        }
    }
}
