using System;

public class Kata {

 public static string Shark(int pontoonDistance, int sharkDistance, int youSpeed, int sharkSpeed, bool dolphin) {
  decimal you = 0;
  decimal shark = 0;
  decimal half = 0;
  
   try {
    you = pontoonDistance / youSpeed;
    shark = sharkDistance / sharkSpeed;
    half = sharkDistance / (sharkSpeed/2);
    }
    
     catch (DivideByZeroException) {
     Console.WriteLine("Division by zero.");
     }
     
     if (you < half && dolphin == true) {
      Console.WriteLine(pontoonDistance + "/" + sharkDistance + "/" + youSpeed + "/" + sharkSpeed);
      Console.WriteLine(you + "/" + half + "true");
      return "Alive!";
     }
        
      else if (you < shark && dolphin == false) {
       Console.WriteLine(pontoonDistance + "/" + sharkDistance + "/" + youSpeed + "/" + sharkSpeed);
       Console.WriteLine(you+"/"+shark+"false");
       return "Alive!";
      }
      
       else {
        Console.WriteLine(you + "/" + half + "true");
        Console.WriteLine(you + "/" + shark + "false");
        return "Shark Bait!";
       }
       
    }
}
