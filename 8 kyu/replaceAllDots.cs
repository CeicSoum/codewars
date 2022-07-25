using System.Text.RegularExpressions;
using System;

public class Kata {

  public static string ReplaceDots(string str) {
   Console.WriteLine(str);
   
   if ( str != "no dots") {
    string replace = Regex.Replace(str, "[^A-z0-9]", "-"); 
    return replace;
   }
   
   else {
    string test = "no dots";
    return test;
    }
    
  }
}
