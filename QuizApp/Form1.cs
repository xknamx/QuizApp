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
            //Question型リストquestionを新しく作り
            {
                //Questionクラスで設定したQuestion型の要素を代入して追加
                new Question
                {
                    Text = "日本の首都はどこですか？",
                    Options = new string[] { "大阪", "東京", "京都", "福岡" },
                    CorrectOption = 1
                },

                new Question
                {
                    Text="次のうち、２＋２の答えはどれですか？",
                    Options =new string[]{"3","4","5","6"},
                    CorrectOption=1
                }

                //ここに質問を追加

                
            };
            currentQuestionIndex = 0;
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

                //ラジオボタンにそれぞれ設定した4択を順番に表示
                option1RadioButton.Text = question.Options[0];
                option2RadioButton.Text = question.Options[1];
                option3RadioButton.Text = question.Options[2];
                option4RadioButton.Text = question.Options[3];
            }
            else  //現在の問題番号がquestionリストの要素数以上の値
            {
                questionLabel.Text = "これ以上の質問はありません";
                option1RadioButton.Visible = false;
                option2RadioButton.Visible = false;
                option3RadioButton.Visible = false;
                option4RadioButton.Visible = false;
                submitButton.Visible = false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var question = questions[currentQuestionIndex];
            //questionリストのうち現在の問題番号の要素をquestion変数として取り出す
            int selectOption = -1;
            //選択中の回答の値（初期値は-1を代入）

            if (option1RadioButton.Checked) selectOption = 0;
            if (option2RadioButton.Checked) selectOption = 1;
            if (option3RadioButton.Checked) selectOption = 2;
            if (option4RadioButton.Checked) selectOption = 3;
           //それぞれ選択中のラジオボタンに応じて選択中の回答の値を代入しなおす
           //◆if文の内容が１行なら｛｝は省略できる

            if (selectOption==question.CorrectOption)
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
    }

    //クイズ文、選択支リスト、回答番号の設定を保持するQuestionクラス
    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectOption { get; set; }
    }
}
