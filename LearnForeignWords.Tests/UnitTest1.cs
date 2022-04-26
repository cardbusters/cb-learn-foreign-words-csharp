using Xunit;

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
