using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {

  public static string PigIt(string str) {
  
    List<string> newList = new List<string>();
    string final = "", result = "";
    string[] words = str.Split(' ');
    
    foreach (string word in words) {
    result = string.Join("", word.Skip(1)) + word[0];
    
    if ( word != "!") {
    result += "ay";
    }
    
    newList.Add(result);
    }
    
    foreach (string pig in newList) {
    final += pig + " "; 
    }
    
    final = final.Remove(final.Length - 1, 1);  
    Console.WriteLine(final);
    return final;
  }
}
