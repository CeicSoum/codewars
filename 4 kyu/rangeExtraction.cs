using System;

public class RangeExtraction {
  
   public static string Extract(int[] args) {

      string result = "";

      for (int i = 0; i < args.Length; i++) {
         int range = args[i];
         result += range;

         for (int j = i + 1; j <= args.Length; j++) {
           
            if (j == args.Length || args[j] != range + (j - i)) {
              
               if (j - i >= 3) {
                  result += "-" + args[j - 1];
                  i = j - 1;
               }
              
               result += ",";
               break;
            }
           
         }
      }
     
      result = result.Remove(result.Length - 1, 1).ToString();
      Console.WriteLine(result);
      return result;
   }
}
