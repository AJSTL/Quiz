using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quiz
{   // ChooseOne extends Question
    class ChooseOne : Question
    {
        internal List<string> Options { get; set; }

        internal override string Answer { get; set; }
        public ChooseOne(string questionText, List<string> options, string answer) : base(questionText)
        {
            Options = options;
            Answer = answer;
        }
        public override void Display() // overrides the virtual method defined in parent class
        {
            // print the question text
            Console.WriteLine(QuestionText);
            // iterate through the answer options, one line at a time 
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("     " + Options[i]);
            }
            Console.Write("Answer: ");
            // receive answer input
            string input = Console.ReadLine();
            UserInput = input;
        }
    }

}
