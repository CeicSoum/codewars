using System.Collections.Generic;
using System.Linq;
using System;

public class Kata {

    public static int GetUnique(IEnumerable<int> numbers) {
        int[] arr = numbers.ToArray();
        int unique = arr.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key).First();
        Console.WriteLine("The unique number is " + unique);
        return unique;
    }
  
}
