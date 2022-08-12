using System;
using System.Text.RegularExpressions;

public class Kata {

    public static bool Alphanumeric(string str) {
        Console.WriteLine(str);

        if (String.IsNullOrWhiteSpace(str) == true || str.Contains(" ") == true || str.Contains("_") == true) {
            return false;
        }

        else if (Regex.IsMatch(str, @"^[a-zA-Z0-9]+$") == true) {
            return true;
        }

        return false;
    }
}
