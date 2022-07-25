using System;

public static class Kata {

 public static string buildString(string[] args) {
  return String.Format("I like {0}!", String.Join(", ", args));
 }
 
}
