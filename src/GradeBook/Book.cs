using System.Collections.Generic;
using System;
namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(String name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.High = Math.Max(grade , result.High);
                result.Low = Math.Min(grade , result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
    }
}