using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Question
    {
        public string QuestionText { get; set; }
        public enum AnswerTypes { CheckBox, MultiChoice, TrueFalse }
        public AnswerTypes AnswerType { get; set; }

        public Question(string questionText, AnswerTypes answerType)
        {
            QuestionText = questionText;
            AnswerType = answerType;

        }

        public void PrintQuestion(Question question) 
        {
            Console.WriteLine(question.QuestionText);
        }


    }

}
