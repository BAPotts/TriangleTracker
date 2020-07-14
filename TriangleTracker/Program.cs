using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Is it a triangle? Enter side 1: ");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 2: ");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 3: ");
      int side3 = int.Parse(Console.ReadLine());
    }
  }
}