public static class StringExtensions {

 public static bool IsUpperCase(this string text) {
  string uppercase = text.ToUpper();
  
  if (text != uppercase) {
   return false;
  }
  
  else {
   return true;
  }
  
  }
}
