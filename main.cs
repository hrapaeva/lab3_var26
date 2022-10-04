using System;

class Program {
  public static void Main (string[] args) {
      Console.WriteLine("Введите x: ");
      double x = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите y: ");
      double y = Convert.ToDouble(Console.ReadLine());

      if ((Math.Abs(x+y) + Math.Abs(y-x) <= 12) && (x*x + y*y <= 36)) {
      if (y >= -2*x + 6) 
        Console.WriteLine($"Точка находится в закрашенной области"); 
      else if ((y >= 2*x + 6) && (y >= -2*x - 6))  
        Console.WriteLine($"Точка находится в закрашенной области"); 
      else if ((x <= 0) && (y <= 0) && (y <= -2*x - 6)) 
        Console.WriteLine($"Точка находится в закрашенной области"); 
      else if ((x >= 0) && (y <= 0) && (y <= -2*x + 6) && (y <= 2*x - 6))
        Console.WriteLine($"Точка находится в закрашенной области"); 
      else 
        Console.WriteLine($"Точка вне закрашенной области"); 
      }
      else  Console.WriteLine($"Точка вне данной области");
 }
}
