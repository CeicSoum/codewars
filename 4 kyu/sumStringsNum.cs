using System;
using System.Linq;
using System.Numerics;

public static class Kata {
  
   public static string sumStrings(string a, string b) {
      int difference = 0;
      int length = a.Length;
      string result = "";
      bool carry = false;

      if (a.Length > b.Length) {
         difference = a.Length - b.Length;
         string num = "";
        
         for (int i = 0; i < difference; i++) {
            num += "0";
         }

         num += b;
         b = num;
      }

      if (b.Length > a.Length) {
         difference = b.Length - a.Length;
         string num = "";

         for (int j = 0; j < difference; j++) {
            num += "0";
         }

         num += a;
         a = num;
      }

      for (int k = a.Length - 1; k >= 0; k--) {
         int count = 0;
         count = ((a[k] - 48) + (b[k] - 48));

         if (carry == true) {
            count++;
         }

         if (count <= 9) {
            carry = false;
         }

         if (count > 9) {
            carry = true;
            count -= 10;
         }

         result += count.ToString();

         if (carry == true && k == 0) {
            result += "1";
         }

      }

      char[] arr = result.ToCharArray();
      Array.Reverse(arr);

      result = new String(arr);

      if (result[0] == '0') {
         result = result.Remove(0, 1);
      }

      Console.WriteLine(result);
      return result;
   }
}
