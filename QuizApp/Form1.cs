using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        //Questionクラスを格納するリストquestionsの領域を確保する
        private int currentQuestionIndex;
        //現在のクイズ番号示す値
        QuizListManager quizListManager;

        public Form1()
        {
            InitializeComponent();
            LoadQuestion();
            DisplayQuestion();
        }

        private void LoadQuestion()
        //クイズの内容を読み込むメソッド
        {
            questions = new List<Question>
            {
                new Question("日本の首都はどこですか？",new string[] { "大阪", "東京", "京都", "福岡" }, 1),
                new Question("次のうち、２＋２の答えはどれですか？",new string[] {"3","4","5","6" }, 1)
                
                //ここに質問を追加
            };
            currentQuestionIndex = 0;
            //現在の問題番号の初期値に0を代入
        }

        private void DisplayQuestion()
        //クイズをフォームに表示するメソッド
        {
            if (currentQuestionIndex < questions.Count)
            //現在のクイズの問題番号がquestionリストの要素数よりも小さければ
            {
                var question = questions[currentQuestionIndex];
                //questionリストのうち現在の問題番号の要素をquestion変数として取り出し、

                //questionLabelに問題文を表示
                questionLabel.Text = question.Text;

                //設定した4択を渡してラジオボタンに表示させるメソッドを呼び出す
                DisplayOptions(question.Options);
            }
            else  //現在の問題番号がquestionリストの要素数以上の値
            {
                //問題が残っていないことを示すメソッドを呼び出す
                showEndOfQuiz();
            }
        }

        private void DisplayOptions(string[] options)
        {
            option1RadioButton.Text = options[0];
            option2RadioButton.Text = options[1];
            option3RadioButton.Text = options[2];
            option4RadioButton.Text = options[3];
        }

        private void showEndOfQuiz()
        {
            questionLabel.Text = "これ以上の質問はありません";
            option1RadioButton.Visible = false;
            option2RadioButton.Visible = false;
            option3RadioButton.Visible = false;
            option4RadioButton.Visible = false;
            submitButton.Visible = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var question = questions[currentQuestionIndex];
            //questionリストのうち現在の問題番号の要素をquestion変数として取り出す

            int selectOption = GetSelectedOption();
            //選択中のラジオボタンに応じて選択中の回答の値を代入するメソッドの戻り値を代入

            if (selectOption == question.CorrectOption)
            //選択中の回答の値が設定した回答の値と同じなら
            {
                resultLabel.Text = "正解！";
            }
            else
            {
                resultLabel.Text = "不正解。正しい答えは：" + question.Options[question.CorrectOption];
                //間違っていれば四択配列から回答番目の要素を取り出して表示する
            }

            currentQuestionIndex++;
            //問題番号の値を１増やす
            DisplayQuestion();
            //DisplayQuestionメソッドを呼び出して次の問題を表示させる

        }

        private int GetSelectedOption()
        {
            //選択中のラジオボタンに応じて回答番号の値をint型で返すメソッド
            if (option1RadioButton.Checked) return 0;
            if (option2RadioButton.Checked) return 1;
            if (option3RadioButton.Checked) return 2;
            if (option4RadioButton.Checked) return 3;
            //◆if文の内容が１行なら｛｝は省略できる

            return -1;
            //当てはまらない場合は-1を返す
        }




        private void ExitMenuClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quizManagerViewClicked(object sender, EventArgs e)
        {
            if (quizListManager.Visible != true)
            {
                //palletウィンドウが開いてない場合は新しくインスタンスを生成して開きなおす
                this.quizListManager = new QuizListManager();
                quizListManager.Show();
            }
            else
            {
                //そうでなければ開いているpalletウィンドウにフォーカスをあてる
                quizListManager.Activate();
            }

        }
    }

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
