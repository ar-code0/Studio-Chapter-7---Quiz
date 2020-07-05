using StudioNS;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StudioNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***    ANGULAR QUIZ    ***");
            Console.ResetColor();

            //Multiple choice Part
            MultipleChoice part1 = new MultipleChoice(Dictionnaries.mcQuestions, Dictionnaries.mcCorrects);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPART (1)");
            Console.ResetColor();
            Console.WriteLine("INSTRUCTIONS: Choose one answer (e.g. 2 for the second answer)");

            part1.DisplayQuestions();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">>>  Part (1) Summary  <<<\n");
            Console.ResetColor();
            int mcResult = part1.CorrectAnswers(part1.UserAns, part1.Corrects);
            

            //Checkbox Part
            Checkbox part2 = new Checkbox(Dictionnaries.cbQuestions, Dictionnaries.cbCorrects);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPART (2)");
            Console.ResetColor();
            Console.WriteLine("INSTRUCTIONS: Choose all that apply (e.g. 12 for the firat and the second answers)");

            part2.DisplayQuestions();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">>>  Part (2) Summary  <<<\n");
            Console.ResetColor(); 
            int cbResult = part2.CorrectAnswersCB(part2.UserAns, part2.Corrects);

            //True or Flase Part
            TrueFalse part3 = new TrueFalse(Dictionnaries.tfQuestions, Dictionnaries.tfCorrects);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPART (3)");
            Console.ResetColor(); 
            Console.WriteLine("INSTRUCTIONS: Enter '1' for 'true' or '2' for 'false'");

            part3.DisplayQuestions();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">>>  Part (3) Summary  <<<\n");
            Console.ResetColor(); 
            int tfResult = part3.CorrectAnswers(part3.UserAns, part3.Corrects);

            //Aggregate score
            int finalScore = mcResult + cbResult + tfResult;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n>>>  Your score is : " + finalScore + "/11  <<<");
            Console.ResetColor();

            //Bonus Questions
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBONUS QUESTIONS");
            Console.ResetColor();

            TextAnswer.AnswerValidation("Explain why programmers use libraries", 80);
            TextAnswer.AnswerValidation("Explain what is Angular, why is it useful, and what are its components", 500);

        }
    }
}

