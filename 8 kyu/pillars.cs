public static class Kata {

 public static int Pillars(int numPill, int dist, int width) {
   if (numPill >= 2 && (dist >= 10 && dist <=30) && (width >= 10 && width <=50)) {
   int first = numPill - 1;
   int second = dist * 100;
   int third = (numPill - 2) * width;
   int formula = first * second + third;
   return formula;
  }
  
  else {
   return 0;
  }
  
  }
}
