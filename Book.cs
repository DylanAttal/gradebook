using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book()
    {
      grades = new List<double>();
    }
    List<double> grades = new List<double>();

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }
  }
}