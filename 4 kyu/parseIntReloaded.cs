using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

public class Parser {

   public static int ParseInt(string s) {
   
      s = s.Replace("-", " ");
      s = s.Replace(" and ", " ");
      int result = 0;
      string[] split = s.Split(" ");
      Console.WriteLine(s);
      bool pass = false;
      
      Dictionary < string, int > d = new Dictionary < string, int > ();
      d.Add("zero", 0);
      d.Add("one", 1);
      d.Add("two", 2);
      d.Add("three", 3);
      d.Add("four", 4);
      d.Add("five", 5);
      d.Add("six", 6);
      d.Add("seven", 7);
      d.Add("eight", 8);
      d.Add("nine", 9);
      d.Add("ten", 10);
      d.Add("eleven", 11);
      d.Add("twelve", 12);
      d.Add("thirteen", 13);
      d.Add("fourteen", 14);
      d.Add("fifteen", 15);
      d.Add("sixteen", 16);
      d.Add("seventeen", 17);
      d.Add("eighteen", 18);
      d.Add("nineteen", 19);
      d.Add("twenty", 20);
      d.Add("thirty", 30);
      d.Add("forty", 40);
      d.Add("fifty", 50);
      d.Add("sixty", 60);
      d.Add("seventy", 70);
      d.Add("eighty", 80);
      d.Add("ninety", 90);
      d.Add("hundred", 100);
      d.Add("thousand", 1000);
      d.Add("million", 1000000);

      for (int i = 0; i < split.Length; i++) {
         d.TryGetValue(split[i], out int n);

         if (i + 1 < split.Length && split[i + 1] == "million") {
            result += d[split[i]] * 1000000;
            i++;
            pass = true;
         }

         if (i + 1 < split.Length && split[i + 1] == "thousand") {
            result += d[split[i]] * 1000;
            i++;
            pass = true;
         }

         if (i + 2 < split.Length && split[i + 1] != "hundred" && split[i + 2] == "thousand") {
            result = (d[split[i]] + d[split[i + 1]]) * 1000;
            i += 2;
            pass = true;
         }

         if (i + 2 < split.Length && split[i + 1] == "hundred" && split[i + 2] == "thousand") {
            result = (d[split[i]] * d[split[i + 1]]) * 1000;
            i += 2;
            pass = true;
         }

         if (i + 3 < split.Length && split[i + 3] == "thousand") {
            result = ((d[split[i]] * d[split[i + 1]]) + d[split[i + 2]]) * 1000;
            i += 4;
            pass = true;
         }

         if (i + 4 < split.Length && split[i + 4] == "thousand") {
            result = ((d[split[i]] * d[split[i + 1]]) + d[split[i + 2]] + d[split[i + 3]]) * 1000;
            i += 4;
            pass = true;
         }

         if (i + 1 < split.Length && split[i + 1] == "hundred") {
            result += d[split[i]] * 100;
            i++;
            pass = true;
            
         } 
         
         else if (pass == false) {
            result += n;
         }

         pass = false;
      }

      Console.WriteLine(result);
      return result;
   }
}
