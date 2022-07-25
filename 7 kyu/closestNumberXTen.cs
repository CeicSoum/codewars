using System;

public class Kata {

 public int ClosestMultiple10(int num) {
  int newNum = num;
  
   if ( num % 10 >=0 && num % 10 < 5) {
   newNum = num - (num%10);
   }
   
   else if ( num % 10 >=5 && num % 10 < 10) {
   newNum = num + (10 - num%10);
   }
      
   Console.WriteLine("The closet number multiple of 10 for " + num + " is " + newNum);
   return newNum;
   }
}
