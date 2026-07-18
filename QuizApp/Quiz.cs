using System.Drawing;
using System.Dynamic;
using System.Reflection.Metadata;

namespace QuizApp
{
    public class Quiz
    {
        private Question[] questions;
        private int userChoice = 0;
        private int score = 0;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz(Question[] questions)
        {
            DisplayQuestions(questions);
            GetResult(questions, score);
        }

        private void DisplayQuestions(Question[] questions)
        {
            foreach (var question in questions)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(question.Text);
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < question.Options.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write(i+1);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine($". {question.Options[i]}");
                }
                System.Console.Write("Tell us your answer (number): ");
                int.TryParse(Console.ReadLine(), out userChoice);

                validateChoice(userChoice, question);
            }
        }

        private void validateChoice(int userChoice, Question question)
        {
            if(userChoice >= 1 && userChoice < 4)
            {
                userChoice -= 1;
                if (question.IsCorrect(userChoice))
                {
                    System.Console.WriteLine("Correct");
                    incrementScore(ref score);
                }
                else
                {
                    System.Console.WriteLine($"Incorrect. The answer is {question.Options[question.CorrectOptionIndex]}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Invalid choice, please enter the number that corresponds to your choice of answer");
                Console.ResetColor();
            }
        }

        private void incrementScore(ref int score)
        {
            score++;
        }

        private void GetResult(Question[] questions, int score)
        {
            System.Console.WriteLine($"You got {score}/{questions.Length} correct.");
            if((double)score/questions.Length <= 0.33)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Try again next time.");
            }
            else if((double)score/questions.Length <= 0.66)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine("Great Work.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Excellent.");
            }
        }
    }
}