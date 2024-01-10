using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam
{
    internal class Exam
    {
        public int ExamTime { get; set; }
        public int NumOfQuestions { get; set; }
        public string MCQ { get; set; }

        public int ExamType { get; set; }
        public Exam()
        {
            
        }
        public Exam(int _ExamTime , int _NumOfQuestions)
        {
            this.NumOfQuestions = _NumOfQuestions;
            this.ExamTime= _ExamTime;
                        
        }
        Answers answer = new Answers();
        List<Answers> answerlist = new List<Answers>();
        Question question= new Question();
        List<Question> QuestionList = new List<Question>();
        public void MCQQuestions()
        {
            Console.WriteLine("MCQ Question");
            Console.WriteLine("Please Enter The Number of Questions You want to Enter in the MCQ Part : ");
            NumOfQuestions = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumOfQuestions; i++)
            {
                
                Console.WriteLine($"Please Enter The Body of the Question Number {i}");
                string Body2= Console.ReadLine();
                Console.WriteLine($"Please Enter The Marks of the Question Number {i}");
                int Mark2= int.Parse(Console.ReadLine());
                QuestionList.Add(new Question { Body = Body2, Mark = Mark2 });
                for (int k =1; k <= 3; k++)
                {
                    Console.WriteLine($"Please Enter The Choice Number {k}");   
                    string AnswerText1= Console.ReadLine();
                    answerlist.Add(new Answers { AnswerText = AnswerText1 , AnswerID= k });
                }
            Console.WriteLine("Please Specify The Right Answer : ");
            int CorrectAns = int.Parse(Console.ReadLine());
                answerlist.Add(new() { CorrectAnswer = CorrectAns });
            }
        }

        public virtual void ShowExam()
        {
            Exam exam = new Exam();
            Subject sub = new Subject();
            Console.WriteLine($"Exam Type : {ExamType} ");
            for (int i = 1; i<=QuestionList.Count; i++)
            {
                Console.WriteLine($"Question({i}) ");
                for (int g = 1; g<=QuestionList.Count;g++)
                {
                    Console.WriteLine($"{QuestionList[g].Body} \n Possible Marks : {QuestionList[g].Mark}");
                    for (int a = 1; a <= answerlist.Count; a++)
                    {
                        Console.WriteLine($"{answerlist[a].AnswerID}) {answerlist[a].AnswerText} " );
                    }
                }
                
                Console.WriteLine("==================================================");
                Console.WriteLine("Please Enter The Number of Your Answer : \n");
                int CorRes=int.Parse(Console.ReadLine());
                switch(CorRes)
                {
                    case 1:
                        answerlist[i].AnswerID = CorRes; break;
                    case 2:
                        answerlist[i].AnswerID = CorRes; break;
                    case 3:
                        answerlist[i].AnswerID = CorRes;break;
                    default :
                        Console.WriteLine("Incorrect Input , Default Value is Taken (1)");
                        answerlist[i].AnswerID = CorRes; break;
                }
            }
            Console.WriteLine($"The Correct Answers Are");
            for (int ans = 1; ans <= answerlist.Count; ans++)
            {
                Console.WriteLine($"{answerlist[ans].CorrectAnswer}");
            }
            Console.WriteLine("Thank You for Taking the Exam :) Best of Luck");
        }

        
    }
    internal class FinalExam : Exam
    {
        public double Grade { get; set; }
        public FinalExam(int _ExamTime, int _NumOfQuestions) : base(_ExamTime, _NumOfQuestions)
        {
            this.ExamTime = _ExamTime;
            this.NumOfQuestions = _NumOfQuestions;
            
        }
        public FinalExam(int _ExamTime, int _NumOfQuestions , double grade) : base(_ExamTime, _NumOfQuestions)
        {
            this.ExamTime = _ExamTime;
            this.NumOfQuestions = _NumOfQuestions;
            this.Grade= grade;
        }

        Answers answer = new Answers();
        List<Answers> answerlist = new List<Answers>();
        Question question = new Question();
        List<Question> QuestionList = new List<Question>();

        public void TrueOrFalse()
        {
            Console.WriteLine("True Or False Question");
            Console.WriteLine("Please Enter The Number Of Questions You want to Enter");
            NumOfQuestions= int.Parse(Console.ReadLine());
            for (int i = 0; i < NumOfQuestions; i++)
            {
                    Console.WriteLine($"Please Enter The Body of the Question Number {i}");
                    string Body1 = Console.ReadLine();
                    Console.WriteLine("Please Enter The Marks of the Question");
                    int Mark1 = int.Parse(Console.ReadLine());
                    QuestionList.Add(new Question { Body = Body1, Mark = Mark1});
                Console.WriteLine("Please Specify The Right Answer : 1 for true , 2 for false ");
                int CorrectAns = int.Parse(Console.ReadLine());
                answerlist.Add(new() { CorrectAnswer = CorrectAns });

            }
        }


        public new void ShowExam()
        {
            Exam exam = new Exam();
            Subject sub = new Subject();
            if (sub.QType == 1)
            {
                Console.WriteLine($"Exam Type Number is : {sub.QType}");
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    Console.WriteLine($"Question({i}) ");
                    foreach (var ques in QuestionList)
                        Console.WriteLine(ques);

                        foreach (var ans in answerlist)
                            Console.WriteLine(ans);
                    
                    Console.WriteLine("==================================================");
                    Console.WriteLine("Please Enter The Number of Your Answer : \n");
                    int CorRes = int.Parse(Console.ReadLine());
                    switch (CorRes)
                    {
                        case 1: answer.AnswerID = 1; break;
                        case 2: answer.AnswerID = 2; break;
                        case 3: answer.AnswerID = 3; break;
                        default:
                            Console.WriteLine("The Value You've Entered is Incorrect , Default Value is Taken (1)");
                            answer.AnswerID = 1; break;
                    }
                    if (answerlist[i].AnswerID == answerlist[i].CorrectAnswer)
                    {
                        Grade += QuestionList[i].Mark;
                    }
                }
                Console.WriteLine("The Questions And The Answers Are : ");
                for (int j=1;j==NumOfQuestions;j++)
                {
                    Console.WriteLine($"Q{j}) {QuestionList[j].Body}");
                    Console.WriteLine($"The Correct Answer Number is {answerlist[j].CorrectAnswer}");
                }
                Console.WriteLine($"Your Grade is : {Grade}");
                Console.WriteLine("Thank You for Taking the Exam :) Best of Luck");
            }

            else if (sub.QType == 2)
            {
                Console.WriteLine("Questions Type is True Or False");
                for (int i=1; i==NumOfQuestions;i++)
                {
                    Console.WriteLine($"Question{i}) {QuestionList[i].Body} ");
                    Console.WriteLine("Please Enter Your Answer : \n 1)True                                                  2)False\n");
                    int CorRes = int.Parse(Console.ReadLine());
                    switch (CorRes)
                    {
                        case 1: answer.AnswerID = 1; break;
                        case 2: answer.AnswerID = 2; break;
                        default:
                            Console.WriteLine("The Value You've Entered is Incorrect , Default Value is Taken (True)");
                            answer.AnswerID = 1; break;
                    }
                    if (answerlist[i].AnswerID == answerlist[i].CorrectAnswer)
                    {
                        Grade += QuestionList[i].Mark;
                    }
                }
                Console.WriteLine("The Questions And The Answers Are : ");
                for (int j = 1; j == NumOfQuestions; j++)
                {
                    Console.WriteLine($"Q{j}) {QuestionList[j].Body}");
                    Console.WriteLine($"The Correct Answer Number is {answerlist[j].CorrectAnswer}");
                }
                Console.WriteLine($"Your Grade is : {Grade}");
                Console.WriteLine("Thank You for Taking the Exam :) Best of Luck");
                Console.WriteLine("==============================================");
            }

            }
        }


    


    internal class PracticalExam : Exam
    {
        public PracticalExam(int _ExamTime, int _NumOfQuestions) : base(_ExamTime, _NumOfQuestions)
        {
            this.ExamTime= _ExamTime;
            this.NumOfQuestions= _NumOfQuestions;
        }
    }
}
