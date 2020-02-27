using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var grades = new List<double>() { 12.7, 10.3, 6.11 };
      grades.Add(56.1);

      var sum = 0.0;
      foreach (var number in grades)
      {
        sum += number;
      }
      var average = sum / grades.Count;
      // N1 is formatting the number so that it only has one decimal place.
      Console.WriteLine($"The sum of all grades is {sum:N1}.");
      Console.WriteLine($"The average grade is {average:N1}.");

      if (args.Length > 0)
      {
        Console.WriteLine($"Hello {args[0]}!");
      }
      else
      {
        Console.WriteLine("Hello!");
      }
    }
  }
}
