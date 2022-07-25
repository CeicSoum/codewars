using System.Linq;

public static class Kata {

  public static int TotalPoints(string[] games) {
   int point = 0;
    
   for (int i = 0; i < 10; i++) {
    string firstPlayer = games[i].Substring(0, 1);
    string secondPlayer = games[i].Substring(games[i].Length - 1);
    int first = int.Parse(firstPlayer);
    int second = int.Parse(secondPlayer); 
    
    if (first > second) {
     point = point + 3;
    }
    
    else if (first < second) {
     point = point + 0;
    }  
    
    else if (first == second) {
     point = point + 1;
    }
   }
   
    return point;
  }
}
