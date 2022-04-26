using System;

namespace LearnForeignWords.Tests;

internal class Teacher
{    
    internal string ask()
    {
        string[] questionArray = new string[] {"to sleep", "to speak"};
        int randomNumber = new Random().Next(questionArray.Length);
        return questionArray[randomNumber];
    }
}