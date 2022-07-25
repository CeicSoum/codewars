using System;

public class Kata {

  public static string Dot(int n, int m) {
  
  string message = "";
  
  for (int h = 0; h < m; h++) {
  
  message += "+";
  
  for (int i = 0; i < n; i++) {
  message += "---+";
  }
  
  message += "\n|";  
  
  for (int j = 0; j < n; j++) {
  message += " o |";
  }
  
  message += "\n"; 
  }
  
  message += "+";
  
  for (int k = 0; k < n; k++) {
  message += "---+";
  }
  
  Console.WriteLine(message);
  return message;
  }
}
