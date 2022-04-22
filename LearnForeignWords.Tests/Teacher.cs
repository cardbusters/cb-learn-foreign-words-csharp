using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnForeignWords.Tests
{
    public class Teacher
    {
        static List<string> questions = new List<string>(){
            "Question-1",
            "Question-2",
            "Question-3",
            "Question-4",
            "Question-5"
        };
        internal static string ask()
        {
            var rand = new Random();
            var randomQuestion = questions.ElementAt( rand.Next( questions.Count() ) );

            return randomQuestion;
        }
    }
}