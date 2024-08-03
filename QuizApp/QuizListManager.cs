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

        private void SelectedAns(int ans)
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

    }
}
