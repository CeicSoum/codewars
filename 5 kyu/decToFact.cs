using System;
using System.Linq;
using System.Collections.Generic;

public class Dec2Fact {

    public static string dec2FactString(long nb) {
        long num = nb;
        int count = 1;
        string fact = "";
        List<long> tempList = new List<long>();

        while (num >= 1) {
            tempList.Add(num % count);
            num /= count;
            count++;
        }

        tempList.Reverse();
        for (int i = 0; i < tempList.Count; i++) {
            fact += tempList[i].ToString();
        }

        Console.WriteLine(fact);
        return fact;
    }
}
