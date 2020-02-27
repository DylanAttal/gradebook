using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    private List<double> grades = new List<double>();
    private string name;

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var sum = 0.0;
      var highestGrade = double.MinValue;
      var lowestGrade = double.MaxValue;
      foreach (var number in grades)
      {
        sum += number;
        if (number > highestGrade)
        {
          highestGrade = number;
        }
        lowestGrade = Math.Min(number, lowestGrade);
      }
      var average = sum / grades.Count;
      // N1 is formatting the number so that it only has one decimal place.
      Console.WriteLine($"The sum of all grades is {sum:N1}.");
      Console.WriteLine($"The average grade is {average:N1}.");
      Console.WriteLine($"The highest grade is {highestGrade:N1}.");
      Console.WriteLine($"The lowest grade is {lowestGrade:N1}.");
    }
  }
}