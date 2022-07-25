using System;
using System.Linq;

public class Printer {

 public static string PrinterError(String s) {
  int num = 0;
  int error = 0;
  
  if (s.Length >= 1) {
    num += s.Count(x => x == 'a');
    num += s.Count(x => x == 'b');
    num += s.Count(x => x == 'c');
    num += s.Count(x => x == 'd');
    num += s.Count(x => x == 'e');
    num += s.Count(x => x == 'f');
    num += s.Count(x => x == 'g');
    num += s.Count(x => x == 'h');
    num += s.Count(x => x == 'i');
    num += s.Count(x => x == 'j');
    num += s.Count(x => x == 'k');
    num += s.Count(x => x == 'l');
    num += s.Count(x => x == 'm');
    }
    
    error = s.Length - num;
    Console.WriteLine(error + "/" + s.Length);
    return error + "/" + s.Length;
    }
}
