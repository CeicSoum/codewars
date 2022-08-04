using System;

public class Kata {

    public static string High(string s) {
        int count = 0;
        string current = "";
        string[] words = s.Split(' ');

        foreach (string word in words) {
            int temp = 0;

            for (int i = 0; i < word.Length; i++) {
                temp += char.ToUpper(word[i]) - 64;
            }

            if (temp > count) {
                count = temp;
                current = word;
            }

        }
        Console.WriteLine(s);
        Console.WriteLine(current);
        return current;
    }
}
