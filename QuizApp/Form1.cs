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

        public Form1()
        {
            InitializeComponent();
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
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

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
