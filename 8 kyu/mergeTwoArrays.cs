using System;
using System.Linq;

public class Kata {

 public static int[] MergeArrays(int[] arr1, int[] arr2) {
  int count1 = arr1.Length;
  int count2 = arr2.Length;
  int[] newArr = new int[count1 + count2];
  int a = 0, b = 0;
  int i = 0;  

  while (a < count1 && b < count2) {
  
  if (arr1[a] <= arr2[b]) {
    newArr[i++] = arr1[a++];
   }
   
   else {
     newArr[i++] = arr2[b++];
   }
   }

   if (a < count1) {
  
   for (int j = a; j < count1; j++) {
    newArr[i++] = arr1[j];
   }
   }
   
   else {
   
   for (int j = b; j < count2; j++) {
    newArr[i++] = arr2[j];
    }
    }
    
    Array.Sort(newArr);
    newArr = newArr.Distinct().ToArray();
    Console.WriteLine("");
    Console.Write("New array: ");
    
    for (int k = 0; k < newArr.Length; k++) {  
     Console.Write(newArr[k]+" ");  
    } 
    
    return newArr;
  }
}
