using Xunit;

namespace LearnForeignWords.Tests;

public class TeacherTests
{
    [Fact]
    public void TeacherAsksQuestionThenResultShouldBeString()
    {
        Assert.IsType<string>(Teacher.ask());
    }

    [Fact]
    public void TeacherAsksNotNullOrEmptyQuestion()
    {
        Assert.NotEmpty(Teacher.ask());
    }
}
