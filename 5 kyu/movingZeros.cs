using System;
using System.Linq;
using System.Collections.Generic;

public class Kata {

    public static int[] MoveZeroes(int[] arr) {
        int numOfZero = arr.Count(x => x == 0);
        List<int> tempList = new List<int>();

        for (int i = 0; i < arr.Length; i++) {

            if (arr[i] != 0) {
                tempList.Add(arr[i]);
            }

        }

        for (int j = 0; j < numOfZero; j++) {
            tempList.Add(0);
        }

        int[] result = tempList.ToArray();

        for (int k = 0; k < result.Length; k++) {
            Console.Write(result[k] + " ");
        }

        return result;
    }
}
