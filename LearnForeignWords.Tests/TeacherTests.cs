using System.Collections.Generic;
using Xunit;

namespace LearnForeignWords.Tests;

public class TeacherTests
{
    public TeacherTests()
    {
        Teacher.get(new Dictionary<string, string>(){
            {"Question-1", "Answer-1"},
            {"Question-2", "Answer-2"},
            {"Question-3", "Answer-3"},
            {"Question-4", "Answer-4"},
            {"Question-5", "Answer-5"},
        });
    }

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

    [Fact]
    public void TeacherEvaluatesTheAnswerAndSaysCorrect()
    {
        Assert.Equal("Correct", Teacher.evaluate("Question-1", "Answer-1"));
    }

    [Fact]
    public void TeacherGetsTheQuestionareAndAnswersToAsk()
    {
        var questionare = new Dictionary<string, string>(){
            { "Question-1", "Answer-1" }
        };
        Teacher.get(questionare);
        
        Assert.Equal("Question-1", Teacher.ask());
        Assert.Equal("Correct", Teacher.evaluate("Question-1", "Answer-1"));

    }
}
