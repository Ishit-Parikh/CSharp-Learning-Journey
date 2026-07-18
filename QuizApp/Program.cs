using QuizApp;

public class Program
{
    public static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question("What is the capital of Gujarat?", new string[] {"Ahmedabad", "Surat", "Gandhinagar", "Rajkot"}, 2),
            new Question("Which team is accused of cheating the most in the FIFA 2026 WC?", new string[] {"Argentina", "spain", "France", "England"}, 0),
            new Question("How many swords does Zoro from One Piece anime use?", new string[] {"One", "Two", "Three", "Four"}, 2)
        };

        Quiz quiz = new Quiz(questions);
        quiz.StartQuiz(questions);
    }
}