using System;

public class Kata {

  public static bool IsNice(int[] arr) {
   bool nice = true;
   
   if (arr == null || arr.Length == 0) {
    nice = false;
    Console.WriteLine("");
    Console.Write("null is not a nice array");
    return nice;
     } 
     
     else {
      Console.WriteLine("");
      Console.Write("[ ");
      
      foreach (var n in arr) {
       int plus = n + 1;
       int minus = n - 1;
       Console.Write(n+" ");
       bool e1 = Array.Exists( arr, element => element == plus );
       bool e2 = Array.Exists( arr, element => element == minus );
       
       if (e1 == true || e2 == true) {
       }
       else {
       nice = false;
       }
       }
       
       Console.Write("] ");
       
       if (nice == true) {
       Console.Write("is a nice array");
       }
       
       else {
       Console.Write("is not a nice array");
       }
       
       return nice;
     }
  }
}
