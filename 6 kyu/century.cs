using System;

public class Kata {
  
 public static string WhatCentury(string year) {
  string deci = year.Insert(2,".");
  string result = "";
  double num = Convert.ToDouble(deci);
  num = Math.Ceiling(num);
  result = num.ToString();
   
  if (result.EndsWith("1") && result !="11") {
   result += "st";
  }
    
  else if (result.EndsWith("2") && result !="12") {
   result += "nd";
  }
   
  else if (result.EndsWith("3") && result !="13") {
   result += "rd";
  }
   
  else {
   result += "th";
  }
   
   Console.WriteLine(year + " --> " + result);
   return result;
 }
}
