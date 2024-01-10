using System.Diagnostics;

namespace CSharpExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10,"C#");
            Subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam ? (Y || N) :");
            Exam exam = new Exam();

            char inp = char.Parse(Console.ReadLine());
            if (inp=='y' || inp =='Y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                exam.ShowExam();
                Console.WriteLine($"The Elapsed Time is {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Thank You! \nProgram Exit.");
            }
        }
    }
}