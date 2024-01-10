using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam

{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        public int QType { get; set; }
        
        public Subject(int subjectID, string subjectName , Exam examOfSubject , int QTYPE)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            ExamOfSubject = examOfSubject;
            QType = QTYPE;
        }
        public Subject(int subjectID, string subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            
        }
        public Subject()
        {
            
        }

        
        public static void CreateExam()
        {
            Exam exam = new Exam();
            Console.WriteLine("Please Enter the type of Exam you want to create (Practical or Final ) \n for practical press 1 \n for final press 2\n");
            exam.ExamType = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Duration of the Exam");
            int ExamDuration = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many Questions you want to have in the Exam?");
            int NoOfQuestions = int.Parse(Console.ReadLine());
            if (exam.ExamType == 1)
            {
                Exam practical = new Exam(ExamDuration, NoOfQuestions);
                practical.MCQQuestions();

            }
            else if (exam.ExamType == 2)
            {
                Subject sub1 = new Subject();
                FinalExam final = new FinalExam(ExamDuration, NoOfQuestions);
                Console.WriteLine("Please Enter The Type Of Question you want to create : ");
                Console.WriteLine("For MCQ Questions Press 1 : ");
                Console.WriteLine("For True Or False Questions press 2 : ");
                sub1.QType = int.Parse(Console.ReadLine());
                if (sub1.QType == 1)
                {
                    final.MCQQuestions();
                }

                else if (sub1.QType == 2)
                {
                    final.TrueOrFalse();
                }
                else

                    Console.WriteLine("Invalid Input");
            }

            else
            {
                Console.WriteLine("Please Enter a valid Exam Type : 1 for Practical , 2 for Final ");
                exam.ExamType = int.Parse(Console.ReadLine());
            }



        }
    }
}
