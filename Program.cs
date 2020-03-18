using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new quiz object for testing
            Quiz testQuiz = new Quiz();

            // test "true or false" aka boolean
            //Question testQuestionTF = new ChooseBool("True or False: This is a True or False Question.", "true");
            testQuiz.Add(new ChooseBool("True or False Test: This is a True or False Question.", "true"));

            // test "multiple choice" aka choose one answer
           // Question testQuestionMC = new ChooseOne("Multiple Choice: Choose the number one by entering 1.", new List<string> { "1", "2", "3", "4" }, "1");
            testQuiz.Add(new ChooseOne("Multiple Choice Test: Choose the number one by entering 1.", new List<string> { "1", "2", "3", "4" }, "1"));

            // test "checkbox" aka choose more than one answer
            //Question testQuestionCB = new ChooseMulti("Check Box: Choose the numbers one and two by entering 1, 2.", new List<string> { "1", "2", "3", "4" }, new List<string> { "1", "2" });
            testQuiz.Add(new ChooseMulti("Check Box Test: Choose the numbers one and two by entering 1, 2.", new List<string> { "1", "2", "3", "4" }, new List<string> { "1", "2" }));

            // run the test quiz
            testQuiz.Run();

            // grade the test quiz
            testQuiz.Grade();
        }
    }
}
