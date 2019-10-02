using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ilias GradeBook");
            
           while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if(input == "q")
                    break;
                try
                 {
                     var grade = double.Parse(input);
                     book.AddGrade(grade);
                 }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // i can put whatever i want here. This will show it 
                    // everytime the code is being executed
                }

            }
            

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
