using System;

namespace LearnForeignWords.Tests;

internal class Teacher
{    
    string[] questionArray = new string[] {"to sleep", "to speak"};
    internal string ask()
    {
        int randomNumber = new Random().Next(questionArray.Length);
        return questionArray[randomNumber];
    }
}