using System.Drawing;
using System.Dynamic;
using System.Security.Cryptography;

public class Question
{
    public string Text {get; set;}
    public int BasePoints {get; set;}
    public string Answer{get; set;}

    public Question(string text, string answer)
    {
        Text = text; 
        BasePoints = 10;
        Answer = answer;
    }

    public void CheckAnswer()
    {
        string userAnswer= Utilities.ValidateString();
        if (userAnswer == QuestionManager.)
    }
    
}

public class Question1x2 : Question
{
    public Question1x2(string text, string answer) : base (text, answer)
    {
        BasePoints += 5;
    }
}

public class MultipleChoice : Question
{
    public MultipleChoice(string text, string answer, List<string> list) : base (text, answer)
    {
        BasePoints += 10;
    }
}
public class FreeText : Question
{
    public FreeText(string text, string answer) : base (text, answer)
    {
        BasePoints += 20;
    }
}
public class Year : Question
{
    public Year(string text, string answer) : base (text, answer)
    {
        BasePoints += 20;
    }
}