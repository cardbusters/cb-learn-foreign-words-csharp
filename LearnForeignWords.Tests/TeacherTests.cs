using System.Collections.Generic;
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

    [Fact]
    public void TeacherAsksRandomQuestions()
    {
        var first10Questions = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            first10Questions.Add(Teacher.ask());
        }

        var second10Questions = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            second10Questions.Add(Teacher.ask());
        }

        Assert.NotEqual(first10Questions, second10Questions);
    }
}
