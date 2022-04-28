using System;
using System.Collections.Generic;

namespace LearnForeignWords.Tests;

internal class Teacher
{    
    List<string> questionArray = new List<string> {"to sleep", "to speak"};
    internal string ask()
    {
        int randomNumber = new Random().Next(questionArray.Count);
        return questionArray[randomNumber];
    }

    internal void addWord(string stringToAdd)
    {
        questionArray.Add(stringToAdd);
    }
}