using System;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ilias GradeBook");
            book.AddGrade(99.4);
            book.AddGrade(99.9);
            book.AddGrade(57.2);
            book.AddGrade(13.8);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
        }
    }
}
