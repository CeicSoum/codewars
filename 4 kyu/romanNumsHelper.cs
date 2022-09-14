using System;
using System.Linq;
using System.Collections.Generic;

public class RomanNumerals {

   public static string ToRoman(int n) {
      string digits = n.ToString();
      
      string digits = n.ToString();
      string[] first = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
      string[] second = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
      string[] third = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
      string[] fourth = { "", "M", "MM", "MMM"};
      string result = "";

      switch (digits.Length) {
      case 1:
         result = first[digits[0] - '0'];
         break;
      case 2:
         result = second[digits[0] - '0'] + first[digits[1] - '0'];
         break;
      case 3:
         result = third[digits[0] - '0'] + second[digits[1] - '0'] + first[digits[2] - '0'];
         break;
      case 4:
         result = fourth[digits[0] - '0'] + third[digits[1] - '0'] + second[digits[2] - '0'] + first[digits[3] - '0'];
         break;
      }

      Console.WriteLine(result);
      return result;
   }

   public static int FromRoman(string romanNumeral) {

      int result = 0;
      Dictionary<char, int> d = new Dictionary<char, int>() {
       { 'I', 1 },
       { 'V', 5 },
       { 'X', 10 },
       { 'L', 50 },
       { 'C', 100 },
       { 'D', 500 },
       { 'M', 1000 }
      };

      for (int i = 0; i < romanNumeral.Length; i++) {
         d.TryGetValue(romanNumeral[i], out int n);
         
         if (i + 1 < romanNumeral.Length && d[romanNumeral[i + 1]] > d[romanNumeral[i]]) {
            result -= n;
         } 
         
         else {
            result += n;
         }

      }
      
      Console.WriteLine(result);
      return result;
   }
}
