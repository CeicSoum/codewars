using System;

public static class Kata {

  public static int Score(int[] dice) {
   int one = 0,two = 0,three = 0,four = 0,five = 0,six = 0,points = 0;
   
   foreach (int i in dice) {
   
   switch(i) {
   case 1:
   one++;
   break;
   case 2:
   two++; 
   break;
   case 3:
   three++;
   break;
   case 4:
   four++;
   break;
   case 5:
   five++;
   break;
   default:
   six++; 
   break;
  } 
  }
  
    if (one < 3 ) {
    points += 100 * one;
    }
    
    if (one == 3 ) {
    points += 1000;
    }
    
    if (one > 3 ) {
    points += 1000;
    points += (one - 3) * 100;
    }
    
    if (two >= 3 ) {
    points += 200;
    }
    
    if (three >= 3 ) {
    points += 300;
    }
    
    if (four >= 3 ) {
    points += 400;
    }
    
    if (five < 3 ) {
    points += 50 * five;
    }
    
    if (five == 3 ) {
    points += 500;
    }
    
    if (five > 3 ) {
    points += 500;
    points += (five - 3) * 50;
    }
    
    if (six >= 3 ) {
    points += 600;
    }
    
    Console.WriteLine(points);
    return points;
  }
}
