using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata {

  public static bool Digit(this string s) {
   bool newline = s.Contains(Environment.NewLine);
   Regex regex = new Regex(@"^\d$");
   
   if (regex.IsMatch(s) && newline == false) { 
    Console.WriteLine(s+" true");
    return true;
   }
   
   else { 
    Console.WriteLine(s+" false");
    return false;
   }
   
  }
}
