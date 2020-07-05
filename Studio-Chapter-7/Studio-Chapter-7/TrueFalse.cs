using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StudioNS
{
    public class TrueFalse : Questions
    {
        public TrueFalse(Dictionary<string, List<string>> listings, List<int> corrects) : base(listings)
        {
            Corrects = corrects;
        }

        //abstract method belonging to the parent class but not used in this class
        public override int CorrectAnswersCB(List<List<int>> answer, List<List<int>> correct)
        {
            throw new NotImplementedException();
        }

        // Summarizes user's performance indicating which questions they answered correctly, providing the coreect answer for the questions answered incorrectly. It returns at the end the number of correct answers.
        public override int CorrectAnswers(List<int> answer, List<int> correct)
        {
            int cor = 0;
            for (int i = 0; i < answer.Count; i++)
            {
                if (answer[i] == correct[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct Answer");
                    Console.ResetColor();

                    cor++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Answer: : " + answer[i] + "  Correct Answer: : " + correct[i]);
                    Console.ResetColor();
                }
            }
            return cor;
        }

        //displays the question and the potential answers then adds the user's input to the property UserAns
        public override void DisplayQuestions()
        {
            foreach (KeyValuePair<string, List<string>> pair in Listings)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------\n");
                Console.WriteLine(">> " + pair.Key + " (or press enter to exit)" + "\n");
                //int i = 1;
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    Console.WriteLine(i + 1 + " - " + pair.Value[i]);
                }
                Console.WriteLine("\n--------------------------------------------------------------------------------------");
                int input = int.Parse(Validator(1));
                UserAns.Add(input);
            }
        }

        //validates user's nput
        public override string Validator(int num)
        {
            int n;
            List<int> validEntries = new List<int> { 1, 2 };
            string input = Console.ReadLine();
            while (input.Length > num || !int.TryParse(input, out n) || !validEntries.Contains(int.Parse(input)))
            {
                if (input == "")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("please enter a valid answer or press Enter to exit");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
