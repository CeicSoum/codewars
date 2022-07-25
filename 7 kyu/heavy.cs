using System;

public class Kata {

 public static string HeavyMetalUmlauts(string boringText) {
   string newText = boringText;
   newText = newText.Replace('A', '\u00c4');  
   newText = newText.Replace('O', '\u00d6');  
   newText = newText.Replace('a', '\u00e4');  
   newText = newText.Replace('o', '\u00f6');  
   newText = newText.Replace('E', '\u00cb');  
   newText = newText.Replace('U', '\u00dc');  
   newText = newText.Replace('e', '\u00eb');  
   newText = newText.Replace('u', '\u00fc');  
   newText = newText.Replace('I', '\u00cf');  
   newText = newText.Replace('Y', '\u0178');  
   newText = newText.Replace('i', '\u00ef');  
   newText = newText.Replace('y', '\u00ff');  
   
   Console.WriteLine(boringText);
   Console.WriteLine(newText);
   Console.WriteLine("-------------------------------------------");
   return newText;
  }  
}
