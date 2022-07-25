using System;

public static class Kata {

  public static int CountSheeps(bool[] sheeps) {
   int count = 0;
   
   foreach (bool i in sheeps) {
   
   if (i == true) {
   count++;
   }
   
   }
   return count;
  }
}
