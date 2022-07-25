using System;
using System.Linq;
public class Kata
{
  public static int Gimme(double[] inputArray)
  {
    double[] newArray = inputArray;
    int position = 0;
    newArray = newArray.OrderByDescending(c => c).ToArray();
    double middle = newArray[1];
    for (int count = 0; count < inputArray.Length; count++){
    if ( inputArray[count] == middle) {
    position = count;
    }
    }
    Console.WriteLine(position);
    return position;
  }
}
