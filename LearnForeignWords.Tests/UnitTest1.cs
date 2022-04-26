using Xunit;
using System;

namespace LearnForeignWords.Tests;

public class UnitTest1
{
    [Fact]
    public void WhenTeacherAsksTenTimesThenToSleepAndToSpeakShouldBeReturnedAtLeastOnce()
    {
        int     toSleepCount = 0;
        int     toSpeakCount = 0;
        string  teachersQuestion;

        for (int i = 0; i < 10; i++) 
        {
            teachersQuestion = Teacher.ask();

            if (teachersQuestion == "to sleep")
            {
               toSleepCount++;
            }
            else if(teachersQuestion == "to speak")
            {
               toSpeakCount++; 
            }
        }
        Assert.True(toSleepCount > 0 && toSpeakCount > 0);
    }
}

internal static class Teacher
{    
    internal static string ask()
    {
        string[] questionArray = new string[] {"to sleep", "to speak"};
        int randomNumber = new Random().Next(questionArray.Length);
        return questionArray[randomNumber];
    }
}