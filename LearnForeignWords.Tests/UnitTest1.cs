using Xunit;

namespace LearnForeignWords.Tests;

public class UnitTest1
{

    [Fact]
    public void WhenTeachAsksThenToSleepShouldBeReturned()
    {
        Assert.Equal("to sleep", Teacher.ask());
    }
}

internal class Teacher
{
    internal static string ask()
    {
        return "to sleep";
    }
}