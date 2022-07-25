using System.Collections.Generic;
using System.Linq;

public class Kata {

 public static List<int> ReverseList(List<int> list) {
  List<int> reverse = Enumerable.Reverse(list).ToList();
  return reverse;
 }
  
}
