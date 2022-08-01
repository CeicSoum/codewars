using System;
using System.Linq;

public static class Kata {

    public static int CountSmileys(string[] smileys) {
        int count = 0;

        foreach (string smiley in smileys) {

            if (smiley.Length == 2 && (smiley.Substring(0, 1) == ":" || smiley.Substring(0, 1) == ";") && (smiley.Substring(1, 1) == ")" || smiley.Substring(1, 1) == "D")) {
                count++;
            }

            else if (smiley.Length == 3 && (smiley.Substring(0, 1) == ":" || smiley.Substring(0, 1) == ";") && (smiley.Substring(1, 1) == "-" || smiley.Substring(1, 1) == "~") && (smiley.Substring(2, 1) == ")" || smiley.Substring(2, 1) == "D")) {
                count++;
            }

        }
        return count;
    }
}
