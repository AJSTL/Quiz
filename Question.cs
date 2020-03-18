using System;

namespace Quiz
{
    // define parent class Question
    public abstract class Question
    {
        // to give each quiz question a unique identifier and for iterating through them
        private static int questionNumber = 1;
        internal int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        internal virtual string Answer { get; set; }
        internal virtual string UserInput { get; set; }

        public Question(string questionText)
        {
            QuestionNumber = questionNumber++;
            QuestionText = questionText;

        }
        public virtual void Display()
        {
            // print the question text
            Console.WriteLine(QuestionText);
            
            // collect user input 
            string input = Console.ReadLine();
            UserInput = input;
        }
        public virtual bool IsCorrect()
        {
            if (UserInput == Answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
