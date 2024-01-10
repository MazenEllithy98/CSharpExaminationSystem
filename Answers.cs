using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam
{
    internal class Answers
    {
        public int AnswerID { get; set; }

        public string AnswerText { get; set; }

        public int CorrectAnswer { get; set; }
        public Answers()
        {

        }
        public Answers(int CorrAns)
        {
            this.AnswerID = CorrAns;
        }
        public Answers(int answerID, string answerText) 
        {
            this.AnswerID = answerID;
            this.AnswerText = answerText;
        }

        public Answers(int _AnswerID, string _AnsText , int CorrAns )
        {
            this.AnswerID = _AnswerID;
            this.AnswerText = _AnsText;
            this.CorrectAnswer = CorrAns;
        }
        public Answers(int answerID, string answerText, int correctAnswer, Answers[] answerList) : this(answerID, answerText, correctAnswer)
        {
            AnswerList = answerList;
        }

        public Answers[] AnswerList = new Answers[15];

        public override string ToString()
        {
            return $"Answer ID {AnswerID} , Answer Text : {AnswerText} , : Correct Answer ID {CorrectAnswer} ";
        }

    }
}
