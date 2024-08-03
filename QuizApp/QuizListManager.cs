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
    public partial class QuizListManager : Form
    {
        public QuizListManager()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void AddButtonClicked(object sender, EventArgs e)
        {
            string selected = "";
            try
            {
                //DateTableにデータを追加する (追加した列の数と対応した引数で指定する)
                quizDataSet.quizDataTable.AddquizDataTableRow(
                this.questionTextBox.Text,
                this.ans1TextBox.Text,
                this.ans2TextBox.Text, this.ans3TextBox.Text, this.ans4TextBox.Text,
                selected = SelectedAns().ToString());

            }
            catch (System.FormatException)
            {
                MessageBox.Show("入力に誤りがあります");
            }

        }
        public int SelectedAns()
        {
            if (ansRadioButton1.Checked)
            {
                ansRadioButton1.Text = "回答";
                ansRadioButton2.Text = "";
                ansRadioButton3.Text = "";
                ansRadioButton4.Text = "";
                return 0;
            }

            if (ansRadioButton2.Checked)
            {
                ansRadioButton1.Text = "";
                ansRadioButton2.Text = "回答";
                ansRadioButton3.Text = "";
                ansRadioButton4.Text = "";
                return 1;
            }

            if (ansRadioButton3.Checked)
            {
                ansRadioButton1.Text = "";
                ansRadioButton2.Text = "";
                ansRadioButton3.Text = "回答";
                ansRadioButton4.Text = "";
                return 2;
            }

            if (ansRadioButton4.Checked)
            {
                ansRadioButton1.Text = "";
                ansRadioButton2.Text = "";
                ansRadioButton3.Text = "";
                ansRadioButton4.Text = "回答";
                return 3;
            }

            ansRadioButton1.Text = "";
            ansRadioButton2.Text = "";
            ansRadioButton3.Text = "";
            ansRadioButton4.Text = "";
            return -1;
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

                questions.Add(new Question
                {
                    Text = row["問題文"].ToString(),
                    Options = list,
                    CorrectOption = (int)row["回答番号"]
                });
            }

        }


    }
