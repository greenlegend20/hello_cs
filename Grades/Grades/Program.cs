using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;

            book.Name = "Wilson's grade book";
            book.Name = "Wilson's book";
            book.AddGrade(95);
            book.AddGrade(89.1f);
            book.AddGrade(59);
            GradeStats stats = book.ComputeStats();

            Console.WriteLine(book.Name);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }

        static void OnNameChanged(object sender, NameChangeEventArgs args){
            Console.WriteLine($"Grade book name changed from {args.ExistingName} to {args.NewName}");
        }
    }
}
