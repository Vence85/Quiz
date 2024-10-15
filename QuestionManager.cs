class QuestionManager
{
    List<Question>questionList = new List<Question>();
    public QuestionManager()

    {
    // Lägg till 1x2-frågor
    questionList.Add(new Question1x2("Vad är huvudstaden i Sverige?", "Stockholm"));
    questionList.Add(new Question1x2("Vilken färg får man om man blandar röd och vit?", "Rosa"));

    // Lägg till flervalsfrågor
    questionList.Add(new MultipleChoice("Vilket av följande är inte ett primtal?", "1", new List<string> { "2", "3", "5", "1" }));
    questionList.Add(new MultipleChoice("Vilket land är känt som 'Solens rike'?", "Japan", new List<string> { "Kina", "Japan", "Indien", "Thailand" }));

    // Lägg till fritextfrågor
    questionList.Add(new FreeText("Vad heter den längsta floden i världen?", "Amazonfloden"));
    questionList.Add(new FreeText("Vilket år föddes Albert Einstein?", "1879"));

    // Lägg till årtalsfrågor
    questionList.Add(new Year("vilket år landade människan på månen?", "1969"));
    questionList.Add(new Year("Vilket år började andra världskriget?", "1939"));
    }

    public void AskQuestion()
    {
         if (questionList.Count == 0)
    {
        Console.WriteLine("Det finns inga frågor tillgängliga.");
        return;
    }
        Random random = new Random();
        int index = random.Next(0, questionList.Count);
        Question RandomQuestion = questionList[index];
        Console.WriteLine($"Fråga: {RandomQuestion.Text}");
        string answer = Utilities.ValidateString();
        if (RandomQuestion.Answer.Contains(answer))
            {
                
            }
        
    }
}

