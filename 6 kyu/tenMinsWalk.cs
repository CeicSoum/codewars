using System;

public class Kata {
    
    public static bool IsValidWalk(string[] walk) {
        bool valid = false;
        int count = 1;
        string compare = walk[0];

        foreach (string direction in walk) {
            
            if (direction != compare) {
                compare = direction;
                count++;
            }

        }

        if (count == 10) {
            valid = true;
        }

        Console.WriteLine(count);
        return valid;
    }
}
