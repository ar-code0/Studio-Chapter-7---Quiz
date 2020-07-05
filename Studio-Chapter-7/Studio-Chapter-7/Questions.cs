using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace StudioNS
{
    public abstract class Questions
    {
        public Dictionary<string, List<string>> Listings { get; set; }
        public List<int> Corrects { get; set; }
        public List<int> UserAns = new List<int>();

        protected Questions(Dictionary<string, List<string>> listings)
        {
            Listings = listings;
        }

        public abstract int CorrectAnswers(List<int> answer, List<int> correct);
        public abstract int CorrectAnswersCB(List<List<int>> answer, List<List<int>> correct);
        public abstract string Validator(int num);
        public abstract void DisplayQuestions();
    }
}
