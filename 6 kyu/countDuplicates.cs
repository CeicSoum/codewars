using System;
using System.Linq;

public class Kata {

    public static int DuplicateCount(string str) {
        int count = 0;
        str = str.ToLower();
        string newStr = string.Join(" ", str.ToCharArray().Distinct());
        
        for (int i = 0; i < newStr.Length; i++) {
            int c = str.Count(f => (f == newStr[i]));
            
            if (c > 1) {
                count++;
            }

        }
        Console.WriteLine(count);
        return count;
    }
}
