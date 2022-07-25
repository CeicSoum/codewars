public class Kata {

 public static double SumArray(double[] array) {
  double result = 0;
  
  if (array == null || array.Length == 0) {
   return 0;
  }
   
   else {
    foreach (var num in array) {
    result += num;
   }
    
   return result;
  }
   
  }
}
