using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;
using System.Media;
using Newtonsoft.Json;
using System.IO;


namespace QuizApp
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        //Questionクラスを格納するリストquestionsの領域を確保する
        private int currentQuestionIndex;
        //現在のクイズ番号示す値
        QuizListManager quizListManager;
        private MediaPlayer mediaPlayerT;
        private MediaPlayer mediaPlayerF;
        int correctCount;       //正答数のカウント
        Random random;


        public Form1()
        {
            InitializeComponent();
            RoadQuestion();
            DisplayQuestion();
            quizCounter.Text = $"1/{questions.Count}";

            this.quizListManager = new QuizListManager();
            correctCount = 0;

        }

        private void RoadQuestion()
        {
            //JSONファイルが存在する場合、読み込み処理を行う
            if (File.Exists(@"..\..\クイズデータ.json"))
            {
                //jsonファイル内のデータを読み込んで文字列型としてjson変数に代入
                var json = File.ReadAllText(@"..\..\クイズデータ.json");

                //読み取ったJSON文字列をBook型のリストbooksにデシリアライズ
                questions = JsonConvert.DeserializeObject<List<Question>>(json);

                ShuffleQuestion();

            }
            currentQuestionIndex = 0;
            //現在の問題番号の初期値に0を代入

        }

        private void ShuffleQuestion()
        {
            //クイズの並びをシャッフルするメソッド
            random = new Random();

            for (int i = 0; i < questions.Count; i++)
            {
                int randomIndex = random.Next(questions.Count);
                var temp = questions[i];
                questions[i] = questions[randomIndex];
                questions[randomIndex] = temp;

            }
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

                //ラジオボタンの選択を解除するメソッド
                RadioButtonClear();

                //設定した4択を渡してラジオボタンに表示させるメソッドを呼び出す
                DisplayOptions(question.Options);
            }
            else  //現在の問題番号がquestionリストの要素数以上の値
            {
                //問題が残っていないことを示すメソッドを呼び出す
                showEndOfQuiz();
            }
        }

       private void RadioButtonClear()
        {
            option1RadioButton.Checked=false;
            option2RadioButton.Checked=false;
            option3RadioButton.Checked=false;
            option4RadioButton.Checked=false;
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
            questionLabel.Text = $"{questions.Count}問中{correctCount}問正解！\n問題は以上です";
            option1RadioButton.Visible = false;
            option2RadioButton.Visible = false;
            option3RadioButton.Visible = false;
            option4RadioButton.Visible = false;
            submitButton.Visible = false;
            resultLabel.Visible = false;
            quizCounter.Visible = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var question = questions[currentQuestionIndex];
            //questionリストのうち現在の問題番号の要素をquestion変数として取り出す

            int selectOption = GetSelectedOption();
            //選択中のラジオボタンに応じて選択中の回答の値を代入するメソッドの戻り値を代入

            if (selectOption == question.CorrectOption-1)
            //選択中の回答の値が設定した回答の値と同じなら
            {
                resultLabel.Text = "正解！";
                //正解音を流す
                SoundPlayer player = new SoundPlayer("TrueAnswer.wav");
                player.Play();
                correctCount++;
            }
            else
            {
                resultLabel.Text = "不正解。正しい答えは：" + question.Options[question.CorrectOption-1];
                //間違っていれば四択配列から回答番目の要素を取り出して表示する
                SoundPlayer player = new SoundPlayer("FalseAnswer.wav");
                player.Play();
            }

            currentQuestionIndex++;
            //問題番号の値を１増やす
            quizCounter.Text = $"{currentQuestionIndex + 1}/{questions.Count}";

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
                //QuizManagerウィンドウが開いてない場合は新しくインスタンスを生成して開きなおす
                this.quizListManager = new QuizListManager();
                quizListManager.Show();
            }
            else
            {
                //そうでなければ開いているQuizManagerウィンドウにフォーカスをあてる
                quizListManager.Activate();
            }

        }

        
    }

}
