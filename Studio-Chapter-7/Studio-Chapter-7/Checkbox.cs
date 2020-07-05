using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudioNS
{
    public class Checkbox : Questions
    {
        public new List<List<int>> Corrects { get; set; }
        public new List<List<int>> UserAns = new List<List<int>>();
        public Checkbox(Dictionary<string, List<string>> listings, List<List<int>> corrects) : base(listings)
        {
            Corrects = corrects;
        }

        //abstract method belonging to the parent class but not used in this class
        public override int CorrectAnswers(List<int> answer, List<int> correct)
        {
            throw new NotImplementedException();
        }

        //returns whether two lists are equal or not; used in CorrectAnswersCB
        public bool ListEquality(List<int> list1, List<int> list2)
        {
            bool equal = true;
            if (list1.Count != list2.Count)
            {
                equal = false;
                goto breakout;
            }
            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1.Contains(list2[i]))
                {
                    equal = false;
                    goto breakout;
                }
            }
        breakout:
            return equal;
        }

        //turns a list into a string; used in CorrectAnswersCB
        public string PrintList(List<int> list)
        {
            string str = "";
            foreach (int item in list)
            {
                str += item.ToString();
            }
            return str;
        }
        // Summarizes user's performance indicating which questions they answered correctly, providing the coreect answer for the questions answered incorrectly. It returnsat the end the number of correct answers.
        public override int CorrectAnswersCB(List<List<int>> answer, List<List<int>> correct)
        {
            int cor = 0;
            for (int i=0; i < answer.Count; i++)
            {
                if (ListEquality(answer[i], correct[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct Answer");
                    Console.ResetColor();
                    cor++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Answer: : " + PrintList(answer[i]) + "  Correct Answer: : " + PrintList(correct[i]));
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
                Console.WriteLine(">> " + pair.Key + "\n");
                int num = pair.Value.Count; ;
                int i = 1;
                foreach (string item in pair.Value)
                {
                    Console.WriteLine(i + " - " + item);
                    i++;

                }
                Console.WriteLine("--------------------------------------------------------------------------------------");
                string input = Validator(num);
                List<int> inputToList = new List<int>();
                foreach(char character in input)
                {
                    inputToList.Add(int.Parse(character.ToString()));
                }
                UserAns.Add(inputToList);
            }
        }



        //validates user's nput
        public override string Validator(int num)
        {
            int n;
            int[] validEntries = Enumerable.Range(1, num).ToArray();
            string input = Console.ReadLine();

            while (input.Length > num || !int.TryParse(input, out n) || !ArrayContainElement(input, validEntries))
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

        //verifies if a character in a string belongs to an array of integers; used in the validator method
        public bool ArrayContainElement(string str, int[] arr)
        {
            bool result = true;
            int[] test = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                test[i] = (int)Char.GetNumericValue(str[i]);
            }
            foreach (int num in test)
            {
                if (!arr.Contains(num))
                {
                    result = false;
                    goto breakout;
                }
            }
        breakout:
            return result;
        }
    }
}
