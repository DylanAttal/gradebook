using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book2 = new Book();
      book2.AddGrade(90.1);

      var book = new Book();
      book.AddGrade(89.1);

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
    }
  }
}
