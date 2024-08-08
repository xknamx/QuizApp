namespace QuizApp
{
    //クイズ文、選択支リスト、回答番号の設定を保持するQuestionクラス
    public class Question
    {
        public string Text { get; set; }            //問題文  
        public string[] Options { get; set; }       //選択肢
        public int CorrectOption { get; set; }      //答えの番号

        //コンストラクター
        public Question(string text, string[] options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }

}
