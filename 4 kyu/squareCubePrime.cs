using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata {
    
   public static uint SqCubRevPrime(uint n) {
      List < uint > nums = new List < uint > ();
      nums.Add(0);

      for (uint i = 1; i <= 1000; i++) {
         uint square = i * i;
         string digits = square.ToString();
         string reverseSquare = new string(digits.Reverse().ToArray());
         bool squarePrime = true;
         uint formulaSquare = (uint) Math.Floor(Math.Sqrt(Int32.Parse(reverseSquare)));

         if (Int32.Parse(reverseSquare) == 2) {
            squarePrime = true;
         } 
         
         else if (Int32.Parse(reverseSquare) <= 1 || Int32.Parse(reverseSquare) % 2 == 0) {
            squarePrime = false;
         }

         for (uint j = 3; j <= formulaSquare; j += 2) {

            switch (Int32.Parse(reverseSquare) % j) {
            case 0:
               squarePrime = false;
               break;
            }

         }

         uint cube = i * i * i;
         string digitsC = cube.ToString();
         string reverseCube = new string(digitsC.Reverse().ToArray());
         bool cubePrime = true;
         uint formulaCube = (uint) Math.Floor(Math.Sqrt(Int32.Parse(reverseCube)));

         if (Int32.Parse(reverseCube) == 2) {
            cubePrime = true;
         } 
         
         else if (Int32.Parse(reverseCube) <= 1 || Int32.Parse(reverseCube) % 2 == 0) {
            cubePrime = false;
         }

         for (uint k = 3; k <= formulaCube; k += 2) {

            switch (Int32.Parse(reverseCube) % k) {
            case 0:
               cubePrime = false;
               break;
            }

         }

         if (squarePrime == true && cubePrime == true) {
            nums.Add(i);
         }

      }
      
      int l = Convert.ToInt32(n);
      return nums[l];
   }
}
