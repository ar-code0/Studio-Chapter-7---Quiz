using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudioNS
{
    public class MultipleChoice : Questions
    {
        public MultipleChoice(Dictionary<string, List<string>> listings, List<int> corrects) : base(listings)
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
                int num = 0;
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    Console.WriteLine(i + 1 + " - " + pair.Value[i]);
                    num = pair.Value.Count;
                }
                Console.WriteLine("\n--------------------------------------------------------------------------------------");
                int input = int.Parse(Validator(num));
                UserAns.Add(input);
            }
        }

        //validates user's nput
        public override string Validator(int num)
        {
            int n;
            int[] validEntries = Enumerable.Range(1, num).ToArray();
            string input = Console.ReadLine();
            while (input.Length > 1 || !int.TryParse(input, out n) || !validEntries.Contains(int.Parse(input)))
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
