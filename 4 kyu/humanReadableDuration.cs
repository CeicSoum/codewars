using System;

public class HumanTimeFormat {

   public static string formatDuration(int seconds) {
      string time = "now";
      
      if (seconds == 0) {
         Console.WriteLine(time);
         return time;
      }

      //seconds
      else if (seconds > 0 && seconds < 60) {
         time = "del" + seconds + " seconds";
         time = time.Replace("del1 seconds", "1 second");
         time = time.Replace("del", "");
         Console.WriteLine(time);
         return time;
      }

      //minutes
      else if (seconds >= 60 && seconds < 3600) {
         time = "del" + seconds / 60 + " minutes and " + "del" + seconds % 60 + " seconds";
         time = time.Replace("del1 seconds", "1 second");
         time = time.Replace("del1 minutes", "1 minute");
         time = time.Replace(" and del0 seconds", "");
         time = time.Replace("del", "");
         Console.WriteLine(time);
         return time;
      }

      //hours
      else if (seconds >= 3600 && seconds < 86400) {
         time = "del" + seconds / 3600 + " hours, " + "del" + (seconds / 60) % 60 + " minutes and " + "del" + seconds % 60 + " seconds";
         time = time.Replace("del1 seconds", "1 second");
         time = time.Replace("del1 minutes", "1 minute");
         time = time.Replace("del1 hours", "1 hour");
         time = time.Replace(" and del0 seconds", "");
         time = time.Replace("del", "");
         Console.WriteLine(time);
         return time;
      }

      //days
      else if (seconds >= 86400 && seconds < 31536000) {
         int minutes = seconds / 60;
         int hours = minutes / 60;
         int days = hours % 24;
         time = "del" + seconds / 86400 + " days, " + "del" + days + " hours, " + "del" + (seconds / 60) % 60 + " minutes and " + "del" + seconds % 60 + " seconds";
         time = time.Replace("del1 seconds", "1 second");
         time = time.Replace("del1 minutes", "1 minute");
         time = time.Replace("del1 hours", "1 hour");
         time = time.Replace("del1 days", "1 day");
         time = time.Replace(" and del0 seconds", "");
         time = time.Replace("del", "");
         time = time.Replace(", 0 minutes", "");
         time = time.Replace(", 0 hours", "");
         if (!time.Contains("second") && !time.Contains("seconds")) {
            time = time.Replace("hours,", "hours and");
         }
         Console.WriteLine(time);
         return time;
      }

      //years
      else if (seconds >= 31536000 && seconds < 253374062) {
         int minutes = seconds / 60;
         int hours = minutes / 60;
         int day0 = hours % 24;
         int days = hours / 24;
         int years = days % 365;
         time = "del" + seconds / 31536000 + " years, " + "del" + years + " days, " + "del" + day0 + " hours, " + "del" + (seconds / 60) % 60 + " minutes and " + "del" + seconds % 60 + " seconds";
         time = time.Replace("del1 seconds", "1 second");
         time = time.Replace("del1 minutes", "1 minute");
         time = time.Replace("del1 hours", "1 hour");
         time = time.Replace("del1 days", "1 day");
         time = time.Replace("del1 years", "1 year");
         time = time.Replace(" and del0 seconds", "");
         time = time.Replace("del", "");
         if (!time.Contains("second") && !time.Contains("seconds")) {
            time = time.Replace("hours,", "hours and");
         }
         Console.WriteLine(time);
         return time;
         
      } else {
         return time;
      }

   }
}
