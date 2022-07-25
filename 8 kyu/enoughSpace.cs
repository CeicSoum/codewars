using System;

public static class Kata {

 public static int Enough(int cap, int on, int wait) {
 
  if (on + wait <= cap) {
   return 0;
  }
  
  else {
   int nop = (on + wait) - cap;
   return nop;
  }
  
  }
}
