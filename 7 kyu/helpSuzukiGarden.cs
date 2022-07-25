using System;

public class Kata {

  public static string RakeGarden(string garden) {
   string[] words = garden.Split(' ');
   
   for (int i = 0; i < words.Length; i++) {
   
     if (words[i]!="rock" && words[i]!="gravel") {
     words[i]="gravel";
     }
     
    }
    garden = String.Join(" ", words);
    
    Console.WriteLine(garden);
    Console.WriteLine("------------");
    return garden;
  }
}
