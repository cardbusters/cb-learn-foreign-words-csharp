using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnForeignWords.Tests
{
    public class Teacher
    {
        static Dictionary<string, string> questions = new Dictionary<string,string>();

        internal static string ask()
        {
            var rand = new Random();
            var randomQuestion = questions.ElementAt( rand.Next( questions.Count() ) );

            return randomQuestion.Key;
        }

        internal static string evaluate(string question, string answer)
        {
            return "Correct";
        }

        internal static void get(Dictionary<string, string> questionare)
        {
            questions = questionare;
        }
    }
}