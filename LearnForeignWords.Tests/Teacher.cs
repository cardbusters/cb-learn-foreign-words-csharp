using System;

namespace LearnForeignWords.Tests;

internal static class Teacher
{    
    internal static string ask()
    {
        string[] questionArray = new string[] {"to sleep", "to speak"};
        int randomNumber = new Random().Next(questionArray.Length);
        return questionArray[randomNumber];
    }
}