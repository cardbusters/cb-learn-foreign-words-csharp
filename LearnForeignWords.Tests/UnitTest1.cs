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
        Teacher teacher = new Teacher();

        for (int i = 0; i < 10; i++) 
        {
            teachersQuestion = teacher.ask();

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

    [Fact]
    public void WhenAddingTwoQuestionsAndAskedTenTimesThenBothQuestionsShouldBeAsked()
    {
        bool question1Asked = false;
        bool question2Asked = false;
        string question1 = "question1";
        string question2 = "question2";
        Teacher teacher = new Teacher();
        teacher.addWord(question1);
        teacher.addWord(question2);
        
        for (int i = 0; i < 10; i++) 
        {
            string teachersQuestion = teacher.ask();
            if (teachersQuestion == question1)
            {
                question1Asked = true;
            }
            else if(teachersQuestion == question2)
            {
               question2Asked = true; 
            }
        }

        Assert.True(question1Asked && question2Asked);
    }
}
