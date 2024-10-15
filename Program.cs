class Program
{
    static void Main(string[] args)
    {
       bool gameIsRunning = true;
       QuestionManager questionManager = new QuestionManager(); 
       
       while(gameIsRunning)
       {
        
        Console.WriteLine("***********************************");
        Console.WriteLine("Välkommen till quizspelet, gör ett val i menyn!");
        Console.WriteLine("1, Spela quiz!");
        Console.WriteLine("2, Lägg till frågor!");
        Console.WriteLine("3, Ta bort frågor!");
        Console.WriteLine("Q, Avsluta");
        Console.WriteLine("***********************************");
        string menyChoice = Utilities.ValidateString().ToUpper();

        switch(menyChoice)
        {
            case "1":
                
                questionManager.AskQuestion();
                break;
                

            case "2":
            break;

            case "3":
            break;

            case "Q":
                gameIsRunning = false;
                Console.WriteLine("Programmet stängs ned!");
                
                Thread.Sleep(1500);
                break;
        }
       }
    }
}


                
            



