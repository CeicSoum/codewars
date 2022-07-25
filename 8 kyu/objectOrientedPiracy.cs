public class Ship {
 public int Draft;
 public int Crew;
  
 public Ship(int draft, int crew) {
  Draft = draft;
  Crew = crew;
 }
 
 public bool IsWorthIt() {
  double shipOnly = Draft - (Crew * 1.5);
  Console.WriteLine("Draft:" + Draft + " Crew:" + Crew);
  
  if(shipOnly > 20) {
   return true;
  }
  
  else {
   return false;
  }
  
  }
}
