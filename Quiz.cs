using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Quiz
    {
        private List<Question> questions = new List<Question>();

        // to add questions and answers for the quiz
        public void Add(Question questionText)
        {
            questions.Add(questionText);
        }
        public void Run()
        {
            Console.WriteLine("Quiz Time!");
            // iterate through questions and call the override display method for each
            foreach (Question q in questions)
                q.Display();
        }
        public void Grade()
        {
            // iterate for each correct answer 
            int correctAnswers = 0;
            foreach (Question q in questions)
                if (q.IsCorrect())
                    correctAnswers++;
            
            // calculate the percentage
            double grade = (Convert.ToDouble(correctAnswers) / Convert.ToDouble(questions.Count)) * 100;

            // write the number of correct answers out of total questions and the percentage rounded to 2 decimals
            Console.WriteLine(correctAnswers + " correct answers out of " + questions.Count + " = " + Math.Round(grade,2) + "%");

        }
    }
   
}