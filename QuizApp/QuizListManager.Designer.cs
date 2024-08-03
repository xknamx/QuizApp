namespace QuizApp
{
    partial class QuizListManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ansRadioButton1 = new System.Windows.Forms.RadioButton();
            this.ansRadioButton2 = new System.Windows.Forms.RadioButton();
            this.ansRadioButton3 = new System.Windows.Forms.RadioButton();
            this.ansRadioButton4 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.問題文DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢１DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢２DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢３DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢４DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回答番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new QuizApp.QuizDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.問題文DataGridViewTextBoxColumn,
            this.選択肢１DataGridViewTextBoxColumn,
            this.選択肢２DataGridViewTextBoxColumn,
            this.選択肢３DataGridViewTextBoxColumn,
            this.選択肢４DataGridViewTextBoxColumn,
            this.回答番号DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quizDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(387, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(387, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(387, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 367);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(387, 22);
            this.textBox5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "問題文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "選択肢";
            // 
            // ansRadioButton1
            // 
            this.ansRadioButton1.AutoSize = true;
            this.ansRadioButton1.Location = new System.Drawing.Point(533, 286);
            this.ansRadioButton1.Name = "ansRadioButton1";
            this.ansRadioButton1.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton1.TabIndex = 9;
            this.ansRadioButton1.TabStop = true;
            this.ansRadioButton1.UseVisualStyleBackColor = true;
            // 
            // ansRadioButton2
            // 
            this.ansRadioButton2.AutoSize = true;
            this.ansRadioButton2.Location = new System.Drawing.Point(533, 314);
            this.ansRadioButton2.Name = "ansRadioButton2";
            this.ansRadioButton2.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton2.TabIndex = 10;
            this.ansRadioButton2.TabStop = true;
            this.ansRadioButton2.UseVisualStyleBackColor = true;
            // 
            // ansRadioButton3
            // 
            this.ansRadioButton3.AutoSize = true;
            this.ansRadioButton3.Location = new System.Drawing.Point(533, 340);
            this.ansRadioButton3.Name = "ansRadioButton3";
            this.ansRadioButton3.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton3.TabIndex = 11;
            this.ansRadioButton3.TabStop = true;
            this.ansRadioButton3.UseVisualStyleBackColor = true;
            // 
            // ansRadioButton4
            // 
            this.ansRadioButton4.AutoSize = true;
            this.ansRadioButton4.Location = new System.Drawing.Point(533, 370);
            this.ansRadioButton4.Name = "ansRadioButton4";
            this.ansRadioButton4.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton4.TabIndex = 12;
            this.ansRadioButton4.TabStop = true;
            this.ansRadioButton4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "１";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "２";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "３";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "４";
            // 
            // 問題文DataGridViewTextBoxColumn
            // 
            this.問題文DataGridViewTextBoxColumn.DataPropertyName = "問題文";
            this.問題文DataGridViewTextBoxColumn.HeaderText = "問題文";
            this.問題文DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.問題文DataGridViewTextBoxColumn.Name = "問題文DataGridViewTextBoxColumn";
            // 
            // 選択肢１DataGridViewTextBoxColumn
            // 
            this.選択肢１DataGridViewTextBoxColumn.DataPropertyName = "選択肢１";
            this.選択肢１DataGridViewTextBoxColumn.HeaderText = "選択肢１";
            this.選択肢１DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢１DataGridViewTextBoxColumn.Name = "選択肢１DataGridViewTextBoxColumn";
            // 
            // 選択肢２DataGridViewTextBoxColumn
            // 
            this.選択肢２DataGridViewTextBoxColumn.DataPropertyName = "選択肢２";
            this.選択肢２DataGridViewTextBoxColumn.HeaderText = "選択肢２";
            this.選択肢２DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢２DataGridViewTextBoxColumn.Name = "選択肢２DataGridViewTextBoxColumn";
            // 
            // 選択肢３DataGridViewTextBoxColumn
            // 
            this.選択肢３DataGridViewTextBoxColumn.DataPropertyName = "選択肢３";
            this.選択肢３DataGridViewTextBoxColumn.HeaderText = "選択肢３";
            this.選択肢３DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢３DataGridViewTextBoxColumn.Name = "選択肢３DataGridViewTextBoxColumn";
            // 
            // 選択肢４DataGridViewTextBoxColumn
            // 
            this.選択肢４DataGridViewTextBoxColumn.DataPropertyName = "選択肢４";
            this.選択肢４DataGridViewTextBoxColumn.HeaderText = "選択肢４";
            this.選択肢４DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢４DataGridViewTextBoxColumn.Name = "選択肢４DataGridViewTextBoxColumn";
            // 
            // 回答番号DataGridViewTextBoxColumn
            // 
            this.回答番号DataGridViewTextBoxColumn.DataPropertyName = "回答番号";
            this.回答番号DataGridViewTextBoxColumn.HeaderText = "回答番号";
            this.回答番号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.回答番号DataGridViewTextBoxColumn.Name = "回答番号DataGridViewTextBoxColumn";
            // 
            // quizDataTableBindingSource
            // 
            this.quizDataTableBindingSource.DataMember = "quizDataTable";
            this.quizDataTableBindingSource.DataSource = this.quizDataSet;
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "QuizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuizListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ansRadioButton4);
            this.Controls.Add(this.ansRadioButton3);
            this.Controls.Add(this.ansRadioButton2);
            this.Controls.Add(this.ansRadioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuizListManager";
            this.Text = "QuizListManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 問題文DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢１DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢２DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢３DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢４DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回答番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource quizDataTableBindingSource;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ansRadioButton1;
        private System.Windows.Forms.RadioButton ansRadioButton2;
        private System.Windows.Forms.RadioButton ansRadioButton3;
        private System.Windows.Forms.RadioButton ansRadioButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}