using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata {

 public string Rps(string p1, string p2) {
 
  if ((p1 == "rock" && p2 == "scissors") || (p1 == "scissors" && p2 == "paper") || (p1 == "paper" && p2 == "rock")) {
   Console.WriteLine("Player 1 won!");
   return "Player 1 won!";
   }
   
   else if ((p1 == "scissors" && p2 == "rock") || (p1 == "paper" && p2 == "scissors") || (p1 == "rock" && p2 == "paper")) {
    Console.WriteLine("Player 2 won!");
    return "Player 2 won!";
   }
   
   else {
    Console.WriteLine("Draw!");
    return "Draw!";
   }
   
  }
}
