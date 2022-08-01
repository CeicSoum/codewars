using System;

namespace Solution {

    public static class Program {

        public static int factorial(int n) {
            int fact = 1;

            if (n == 0) {
                Console.WriteLine("The factorial of 0 is " + fact);
                return fact;
            }

            else {

                for (int i = n; i > 0; i--) {
                    fact *= i;
                }

                Console.WriteLine("The factorial of " + n + " is " + fact);
                return fact;
            }
        }
    }
}
