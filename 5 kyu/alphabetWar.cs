using System;
using System.Collections.Generic;

public class Kata {
 
 public static string AlphabetWar(string fight) {
        List<char> ch = new List<char>();
        ch.Add(' '); 
        ch.Add(' '); 
        ch.AddRange(fight); 
        ch.Add(' '); 
        ch.Add(' '); 
        int pointLeft = 0, pointRight = 0;
      
       for(int i = 2; i < ch.Count-2; i++) {
       Console.Write(ch[i]);
         
        if (ch[i] == 't' && ch[i-2] != 'j' && ch[i+2] != 'j') {
            
        switch(ch[i-1]) {
        case 'm':
        ch[i-1] = 'w';  
        break;
        case 'q':
        ch[i-1] = 'p';  
        break;
        case 'd':
        ch[i-1] = 'b';  
        break;
        case 'z':
        ch[i-1] = 's';  
        break;
       }
          
        switch(ch[i+1]) {
        case 'm':
        ch[i+1] = 'w';  
        break;
        case 'q':
        ch[i+1] = 'p';  
        break;
        case 'd':
        ch[i+1] = 'b';  
        break;
        case 'z':
        ch[i+1] = 's';  
        break;
       }
          
    }
         
     if (ch[i] == 'j' && ch[i-2] != 't' && ch[i+2] != 't') {
            
        switch(ch[i-1]) {
        case 'w':
        ch[i-1] = 'm';  
        break;
        case 'p':
        ch[i-1] = 'q';  
        break;
        case 'b':
        ch[i-1] = 'd';  
        break;
        case 's':
        ch[i-1] = 'z';  
        break;
       }
          
        switch(ch[i+1]) {
        case 'w':
        ch[i+1] = 'm';  
        break;
        case 'p':
        ch[i+1] = 'q';  
        break;
        case 'b':
        ch[i+1] = 'd';  
        break;
        case 's':
        ch[i+1] = 'z';  
        break;
       }
          
    }
         
   }
     Console.WriteLine("");
    
    foreach(char num in ch) {
      
      switch(num) {
        case 'w':
        pointLeft += 4;
        break;
        case 'p': 
        pointLeft += 3;
        break;
        case 'b':
        pointLeft += 2;
        break;
        case 's':
        pointLeft += 1;
        break;
        case 'm':
        pointRight += 4;
        break;
        case 'q': 
        pointRight += 3;
        break;
        case 'd':
        pointRight += 2;
        break;
        case 'z':
        pointRight += 1;
        break;
       }
        Console.Write(num);
        
     }
     
      Console.WriteLine("");
      
      if (pointLeft > pointRight) {
      Console.WriteLine("Left side wins!");
      return "Left side wins!";   
      }  
        
      else if (pointRight > pointLeft) {
      Console.WriteLine("Right side wins!");
      return "Right side wins!";   
      } 
      
      else {
      Console.WriteLine("Let's fight again!");
      return "Let's fight again!"; 
      }
      
    }
 }
