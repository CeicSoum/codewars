using System;

public static class Kata {

    public static bool IsTwinPrime(int n) {
        bool isPrime = true, firstIsPrime = true, secondIsPrime = true;
        long formula = (long)Math.Floor(Math.Sqrt(n)), formula2 = (long)Math.Floor(Math.Sqrt(n + 2)), formula3 = (long)Math.Floor(Math.Sqrt(n - 2));
        Console.WriteLine(formula2);
        Console.WriteLine(formula3);

        if (n == 2) {
            Console.WriteLine("given " + n + " is not prime");
            Console.WriteLine("hence, " + n + " is not a Twin Prime");
            isPrime = false;
            return false;
        }

        else if (n <= 1 || n % 2 == 0) {
            Console.WriteLine("given " + n + " is not prime");
            Console.WriteLine("hence, " + n + " is not a Twin Prime");
            isPrime = false;
            return false;
        }

        for (int i = 3; i <= formula; i += 2) {

            switch (n % i) {
                case 0:
                    Console.WriteLine("given " + n + " is not prime");
                    Console.WriteLine("hence, " + n + " is not a Twin Prime");
                    isPrime = false;
                    return false;
            }

        }

        if (isPrime == true) {
            Console.WriteLine("given " + n + " is prime");
        }

        for (int i = 3; i <= formula2; i += 2) {

            switch (n % i) {
                case 0:
                    Console.WriteLine(n + " + " + 2 + " = " + (n + 2) + ". which is not prime");
                    firstIsPrime = false;
                    break;
            }
        }

        if (firstIsPrime == true) {
            Console.WriteLine(n + " + " + 2 + " = " + (n + 2) + ", which is prime");
        }

        for (int i = 3; i <= formula3; i += 2) {

            switch (n % i) {
                case 0:
                    Console.WriteLine(n + " - " + 2 + " = " + (n - 2) + ". which is not prime");
                    secondIsPrime = false;
                    break;
            }
        }

        if (secondIsPrime == true) {
            Console.WriteLine(n + " - " + 2 + " = " + (n - 2) + ", which is prime");
        }

        if (firstIsPrime == true && secondIsPrime == true) {
            Console.WriteLine("hence, " + n + " has two prime twins, and it is a Twin Prime.");
            return true;
        }

        else if (firstIsPrime == true && secondIsPrime == false || firstIsPrime == false && secondIsPrime == true) {
            Console.WriteLine("hence, " + n + " has one prime twins, and it is a Twin Prime.");
            return true;
        }

        else if (firstIsPrime == false && secondIsPrime == false) {
            Console.WriteLine("hence, " + n + " is not a Twin Prime.");
            return true;
        }

        return true;
    }
}
