namespace QuizApp
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectOptionIndex { get; set; }

        public Question(string text, string[] options, int correctOptionIndex)
        {
            Text = text;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
        }

        public bool IsCorrect(int selectedOptionIndex)
        {
            return selectedOptionIndex == CorrectOptionIndex;
        }
    }
}