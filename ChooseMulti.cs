using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quiz
{
    // ChooseMulti extends Question
    class ChooseMulti : Question
    {
        internal List<string> Options { get; set; }
        internal new List<string> Answer { get; set; }
        internal new List<string> UserInput { get; set; }
        public ChooseMulti(string questionText, List<string> options, List<string> answers) : base(questionText)
        {
            Options = options;
            Answer = answers;
        }

        public override void Display() // overrides the virtual method defined in parent class
        {
            // print the question text
            Console.WriteLine(QuestionText);
            // iterate through the answer options, one line at a time
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("     "+ Options[i]);
            }
            Console.Write("Answer: ");
            // receive answers input, separated by a comma
            List<string> input = Console.ReadLine().Split(",").ToList();
            UserInput = input;
        }

        public override bool IsCorrect() // overrides the virtual method defined in parent class
        {
            if (Answer.SequenceEqual(UserInput)) // compares the sequence of input to the correct answer
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
