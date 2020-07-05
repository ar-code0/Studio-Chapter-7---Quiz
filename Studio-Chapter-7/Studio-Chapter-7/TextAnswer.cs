using System;
using System.Collections.Generic;
using System.Text;

namespace StudioNS
{
    public class TextAnswer
    {
        public static string ShortAns { get; set; }
        public static string ParagraphAns { get; set; }

        public static void AnswerValidation(string question, int characterLimit)
        {
            Console.WriteLine(question + " (max " + characterLimit + " characters)");
            string answer = Console.ReadLine();
            while (answer.Length > characterLimit)
            {
                Console.WriteLine("Please enter a valid answer");
                answer = Console.ReadLine();
            }
            if(characterLimit == 80)
            {
                ShortAns = answer;
            }
            if(characterLimit == 500)
            {
                ParagraphAns = answer;
            }
        }
    }
}
