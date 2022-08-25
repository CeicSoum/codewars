using System;
using System.Linq;

public class Kata {

  public static string FirstNonRepeatingLetter(string s) {
    string lower = s.ToLower();
    string result = "";
    char[] values = s.ToCharArray();
    char[] letters = lower.ToCharArray(); 
    bool found = false;
    
    for (int i = 0; i < letters.Length; i++) {
      int count = lower.Count(s => s == letters[i]);
      
      if ( count == 1 && found == false) {
      result = values[i].ToString();
      found = true;
      }
      
    }
    
    Console.WriteLine(s);
    return result;
  }
}
