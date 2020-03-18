using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quiz
{
    // ChooseBool extends Question
    class ChooseBool : Question
    {
        internal override string Answer { get; set; }
        public ChooseBool(string questionText, string answer) : base(questionText)
        {
            Answer = answer;
        }
        public override void Display()
        {
            // print the question text
            Console.WriteLine(QuestionText);
            Console.Write("Answer: ");
            
            //receive answer input
            string input = Console.ReadLine();
            UserInput = input;
        }
    }
}
