using System.Collections.Generic;
using System.Linq;
using System;

public class Kata {

public static string SpinWords(string sentence) {
 string newSentence = "";
 string[] words = sentence.Split(' ');
  
 foreach(string word in words) {
    
  if (word.Length >= 5) {
   char[] charArray = word.ToCharArray();
   Array.Reverse( charArray );
   string w = ""; 
   
   foreach (char r in charArray) {  
    w += r;
   }   
   
   newSentence += w;
   newSentence += " ";
   }
   
   else {
    newSentence += word;
    newSentence += " ";
   }
  }
  
   newSentence = newSentence.Remove(newSentence.Length - 1, 1);  
   Console.WriteLine(sentence);
   Console.WriteLine(newSentence);
   return newSentence;
  }
}
