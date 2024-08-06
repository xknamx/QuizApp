using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace QuizApp
{
    public partial class QuizListManager : Form
    {

        public QuizListManager()
        {
            InitializeComponent();
            RoadDate();
            //実行時にデータの読み込みを行う
        }

        public void AddButtonClicked(object sender, EventArgs e)
        {
            try
            {
                //DateTableにデータを追加する (追加した列の数と対応した引数で指定する)
                quizDataSet.quizDataTable.AddquizDataTableRow(
                this.questionTextBox.Text,
                this.ans1TextBox.Text,
                this.ans2TextBox.Text,
                this.ans3TextBox.Text,
                this.ans4TextBox.Text,


                (SelectedAns() + 1).ToString());
                ClearRadioButton();
                SaveDate();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("入力に誤りがあります");
            }
        }
        
        //選択されたラジオボタンを回答として保存する
        public int SelectedAns()
        {
            if (ansRadioButton1.Checked)return 0;
            if (ansRadioButton2.Checked)return 1;
            if (ansRadioButton3.Checked)return 2;
            if (ansRadioButton4.Checked)return 3;
            else{return -1;}
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            //選択した行のデータを削除する
            int row = this.quizDataGrid.CurrentRow.Index;    //現在選択中の行のナンバーを取得しrow変数に代入
            this.quizDataGrid.Rows.RemoveAt(row);           //row行のデータを削除
        }

        private void SaveDate()
        {
            //DateTableの内容をBookオブジェクトのリストに変換
            var questions = new List<Question>();
            foreach (DataRow row in quizDataSet.quizDataTable.Rows)
            {
                var list = new string[]
                {
                    row["選択肢１"].ToString(),
                    row["選択肢２"].ToString(),
                    row["選択肢３"].ToString(),
                    row["選択肢４"].ToString()
                };
                questions.Add(new Question(row["問題文"].ToString(), list, int.Parse(row["回答番号"].ToString())));

            }
            var json = JsonConvert.SerializeObject(questions, Newtonsoft.Json.Formatting.Indented);

            //JSON文字列（json変数の値）をファイルに書き込む
            File.WriteAllText(@"..\..\クイズデータ.json", json);
        }

        //JSONファイルからデータを読み込んでDatesetに収納するメソッド
        private void RoadDate()
        {
            //JSONファイルが存在する場合、読み込み処理を行う
            if (File.Exists(@"..\..\クイズデータ.json"))
            {
                //jsonファイル内のデータを読み込んで文字列型としてjson変数に代入
                var json = File.ReadAllText(@"..\..\クイズデータ.json");

                //読み取ったJSON文字列をBook型のリストbooksにデシリアライズ
                var questions = JsonConvert.DeserializeObject<List<Question>>(json);

                //booksリストに格納した内容をDateTableに追加
                foreach (var question in questions)
                {
                    var option1 = question.Options[0];
                    var option2 = question.Options[1];
                    var option3 = question.Options[2];
                    var option4 = question.Options[3];

                    quizDataSet.quizDataTable.AddquizDataTableRow(
                        question.Text,
                        option1,option2,option3,option4,
                        question.CorrectOption.ToString());
                }
            }
        }
        //選択中の問題情報をテキストボックスに表示させるメソッド
        private void QuizDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (quizDataGrid.CurrentRow != null) //bookDateGridの何かを選択している場合
            {
                DataGridViewRow currentRow = quizDataGrid.CurrentRow;
                // 選択中のセルの一行を取得する

                this.questionTextBox.Text = currentRow.Cells["問題文DataGridViewTextBoxColumn"].Value.ToString();
                this.ans1TextBox.Text = currentRow.Cells["選択肢１DataGridViewTextBoxColumn"].Value.ToString();
                this.ans2TextBox.Text = currentRow.Cells["選択肢２DataGridViewTextBoxColumn"].Value.ToString();
                this.ans3TextBox.Text = currentRow.Cells["選択肢３DataGridViewTextBoxColumn"].Value.ToString();
                this.ans4TextBox.Text = currentRow.Cells["選択肢４DataGridViewTextBoxColumn"].Value.ToString();

            }
        }


        //選択されたラジオボタンの横に回答と表示する
        private void ansRadioButton1Clicked(object sender, EventArgs e)
        {
            ansRadioButton1.Text = "回答";
            ansRadioButton2.Text = "";
            ansRadioButton3.Text = "";
            ansRadioButton4.Text = "";
        }
        private void ansRadioButton2Clicked(object sender, EventArgs e)
        {
            ansRadioButton1.Text = "";
            ansRadioButton2.Text = "回答";
            ansRadioButton3.Text = "";
            ansRadioButton4.Text = "";
        }
         private void ansRadioButton3Clicked(object sender, EventArgs e)
        {
            ansRadioButton1.Text = "";
            ansRadioButton2.Text = "";
            ansRadioButton3.Text = "回答";
            ansRadioButton4.Text = "";
        }
         private void ansRadioButton4Clicked(object sender, EventArgs e)
        {
            ansRadioButton1.Text = "";
            ansRadioButton2.Text = "";
            ansRadioButton3.Text = "";
            ansRadioButton4.Text = "回答";
        }

        private void ClearRadioButton()
        {
            ansRadioButton1.Text = "";
            ansRadioButton2.Text = "";
            ansRadioButton3.Text = "";
            ansRadioButton4.Text = "";
        }

    }

}

