using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata {
  
  public static List<string> Anagrams(string word, List<string> words) {
    List<string> newList = new List<string>();   
    
    for(int i = 0; i < words.Count; i++) {
    string first = String.Concat(word.OrderBy(c => c));
    string second = String.Concat(words[i].OrderBy(c => c));
      
    if (first == second) {
     newList.Add(words[i]);
    }
      
  }
    return newList;
  }
}
