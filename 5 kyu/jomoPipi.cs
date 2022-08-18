using System;
using System.Linq;
using System.Collections.Generic;

public class JomoPipi {

  public static string jumbledString(string s, long n) {
    List<char> even = new List<char>(); 
    List<char> odd = new List<char>(); 
    long count = 0;
    string sentence = "";
    
    while (count < n) {
    
    for (int i = 0; i < s.Length; i++) {
      
        if (i % 2 == 0) {
        even.Add(s[i]);
        } 
      
        if (i % 2 == 1) {
        odd.Add(s[i]);
        }  
      
    }
      
    even.AddRange(odd);
    
    foreach (char c in even) {
        sentence += c;
    }
      
    s = sentence;
    sentence = "";
    even.Clear();
    odd.Clear();
    count++;
    Console.WriteLine(s);  
    
    }

    return s;
    
  }
  
}
