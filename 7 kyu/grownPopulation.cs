using System;

class Arge {

 public static int NbYear(int p0, double percent, int aug, int p) {
  int n = 0;
  double p1 = p0;
  Console.WriteLine(p1 + "/" + percent + "/" + aug + "/" + p); 
   
  while(p1 < p) {
   p1 = Math.Floor(p1 + p1 * (percent / 100) + aug);
   Console.WriteLine(p1); 
   n++;
   }
   
   Console.WriteLine("It takes " + n + " years to reach the demanding population."); 
   return n;
  }
}
