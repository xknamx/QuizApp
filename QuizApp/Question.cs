namespace QuizApp
{
    //クイズ文、選択支リスト、回答番号の設定を保持するQuestionクラス
    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectOption { get; set; }

        public Question(string text, string[] options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
        

    }

}
