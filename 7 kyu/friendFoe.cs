using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata {

  public static IEnumerable<string> FriendOrFoe (string[] names) {
    
    for (int i = 0; i < names.Length; i++) {
    
    if (names[i].Length != 4) {
    names = names.Where((source, index) => index != i).ToArray();
    }
    
    }
    Console.Write("[");
    
    foreach(var name in names) {
    Console.Write(name);
    Console.Write(" ");
    }
    
    Console.Write("]");
    Console.WriteLine("");
    return names;
  }
}
