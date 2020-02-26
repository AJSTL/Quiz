using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Quiz
    {
        public List<Question> Questions { get; set; } = new List<Question>();

        public void AddQuestion(Question question)
        {
            Console.WriteLine("Add a new question to the quiz here: ");
            Questions.Add(question);

        }

        public void PrintQuiz()
        {

        }

        public void GradeQuiz()
        {

        }
    }
}
