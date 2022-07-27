using System;
using System.Linq;

public static class Kata {

public static string AlphabetPosition(string text) {
 string newText = "";
 Console.WriteLine(text);
  
 for (int i = 0; i < text.Length; i++) {
    
  if (text[i].ToString().All(Char.IsLetter) == true) {
   int num = (int)text[i] % 32;
   newText += num.ToString();
   newText += " ";
   }

   }
  
   if (newText.Length > 0) {
    newText = newText.Remove(newText.Length - 1, 1);
   }
  
   Console.WriteLine(newText);
   return newText;
  }
}
