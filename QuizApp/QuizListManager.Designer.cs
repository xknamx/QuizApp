﻿namespace QuizApp
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
            this.quizDataGrid = new System.Windows.Forms.DataGridView();
            this.問題文DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢１DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢２DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢３DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.選択肢４DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回答番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new QuizApp.QuizDataSet();
            this.quizDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.ans1TextBox = new System.Windows.Forms.TextBox();
            this.ans2TextBox = new System.Windows.Forms.TextBox();
            this.ans3TextBox = new System.Windows.Forms.TextBox();
            this.ans4TextBox = new System.Windows.Forms.TextBox();
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quizDataGrid
            // 
            this.quizDataGrid.AllowUserToAddRows = false;
            this.quizDataGrid.AllowUserToDeleteRows = false;
            this.quizDataGrid.AllowUserToOrderColumns = true;
            this.quizDataGrid.AutoGenerateColumns = false;
            this.quizDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.quizDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.問題文DataGridViewTextBoxColumn,
            this.選択肢１DataGridViewTextBoxColumn,
            this.選択肢２DataGridViewTextBoxColumn,
            this.選択肢３DataGridViewTextBoxColumn,
            this.選択肢４DataGridViewTextBoxColumn,
            this.回答番号DataGridViewTextBoxColumn});
            this.quizDataGrid.DataSource = this.quizDataTableBindingSource1;
            this.quizDataGrid.Location = new System.Drawing.Point(12, 30);
            this.quizDataGrid.Name = "quizDataGrid";
            this.quizDataGrid.ReadOnly = true;
            this.quizDataGrid.RowHeadersWidth = 51;
            this.quizDataGrid.RowTemplate.Height = 24;
            this.quizDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.quizDataGrid.Size = new System.Drawing.Size(801, 150);
            this.quizDataGrid.TabIndex = 0;
            this.quizDataGrid.CurrentCellChanged += new System.EventHandler(this.QuizDataGrid_SelectionChanged);
            // 
            // 問題文DataGridViewTextBoxColumn
            // 
            this.問題文DataGridViewTextBoxColumn.DataPropertyName = "問題文";
            this.問題文DataGridViewTextBoxColumn.HeaderText = "問題文";
            this.問題文DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.問題文DataGridViewTextBoxColumn.Name = "問題文DataGridViewTextBoxColumn";
            this.問題文DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 選択肢１DataGridViewTextBoxColumn
            // 
            this.選択肢１DataGridViewTextBoxColumn.DataPropertyName = "選択肢１";
            this.選択肢１DataGridViewTextBoxColumn.HeaderText = "選択肢１";
            this.選択肢１DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢１DataGridViewTextBoxColumn.Name = "選択肢１DataGridViewTextBoxColumn";
            this.選択肢１DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 選択肢２DataGridViewTextBoxColumn
            // 
            this.選択肢２DataGridViewTextBoxColumn.DataPropertyName = "選択肢２";
            this.選択肢２DataGridViewTextBoxColumn.HeaderText = "選択肢２";
            this.選択肢２DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢２DataGridViewTextBoxColumn.Name = "選択肢２DataGridViewTextBoxColumn";
            this.選択肢２DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 選択肢３DataGridViewTextBoxColumn
            // 
            this.選択肢３DataGridViewTextBoxColumn.DataPropertyName = "選択肢３";
            this.選択肢３DataGridViewTextBoxColumn.HeaderText = "選択肢３";
            this.選択肢３DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢３DataGridViewTextBoxColumn.Name = "選択肢３DataGridViewTextBoxColumn";
            this.選択肢３DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 選択肢４DataGridViewTextBoxColumn
            // 
            this.選択肢４DataGridViewTextBoxColumn.DataPropertyName = "選択肢４";
            this.選択肢４DataGridViewTextBoxColumn.HeaderText = "選択肢４";
            this.選択肢４DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.選択肢４DataGridViewTextBoxColumn.Name = "選択肢４DataGridViewTextBoxColumn";
            this.選択肢４DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 回答番号DataGridViewTextBoxColumn
            // 
            this.回答番号DataGridViewTextBoxColumn.DataPropertyName = "回答番号";
            this.回答番号DataGridViewTextBoxColumn.HeaderText = "回答番号";
            this.回答番号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.回答番号DataGridViewTextBoxColumn.Name = "回答番号DataGridViewTextBoxColumn";
            this.回答番号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quizDataTableBindingSource1
            // 
            this.quizDataTableBindingSource1.DataMember = "quizDataTable";
            this.quizDataTableBindingSource1.DataSource = this.quizDataSet;
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "QuizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizDataTableBindingSource
            // 
            this.quizDataTableBindingSource.DataMember = "quizDataTable";
            this.quizDataTableBindingSource.DataSource = this.quizDataSet;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(127, 219);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(686, 22);
            this.questionTextBox.TabIndex = 1;
            // 
            // ans1TextBox
            // 
            this.ans1TextBox.Location = new System.Drawing.Point(127, 289);
            this.ans1TextBox.Name = "ans1TextBox";
            this.ans1TextBox.Size = new System.Drawing.Size(387, 22);
            this.ans1TextBox.TabIndex = 2;
            // 
            // ans2TextBox
            // 
            this.ans2TextBox.Location = new System.Drawing.Point(127, 327);
            this.ans2TextBox.Name = "ans2TextBox";
            this.ans2TextBox.Size = new System.Drawing.Size(387, 22);
            this.ans2TextBox.TabIndex = 3;
            // 
            // ans3TextBox
            // 
            this.ans3TextBox.Location = new System.Drawing.Point(127, 365);
            this.ans3TextBox.Name = "ans3TextBox";
            this.ans3TextBox.Size = new System.Drawing.Size(387, 22);
            this.ans3TextBox.TabIndex = 4;
            // 
            // ans4TextBox
            // 
            this.ans4TextBox.Location = new System.Drawing.Point(127, 402);
            this.ans4TextBox.Name = "ans4TextBox";
            this.ans4TextBox.Size = new System.Drawing.Size(387, 22);
            this.ans4TextBox.TabIndex = 5;
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
            this.ansRadioButton1.Location = new System.Drawing.Point(560, 295);
            this.ansRadioButton1.Name = "ansRadioButton1";
            this.ansRadioButton1.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton1.TabIndex = 9;
            this.ansRadioButton1.TabStop = true;
            this.ansRadioButton1.UseVisualStyleBackColor = true;
            this.ansRadioButton1.CheckedChanged += new System.EventHandler(this.ansRadioButtonClicked);
            // 
            // ansRadioButton2
            // 
            this.ansRadioButton2.AutoSize = true;
            this.ansRadioButton2.Location = new System.Drawing.Point(560, 333);
            this.ansRadioButton2.Name = "ansRadioButton2";
            this.ansRadioButton2.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton2.TabIndex = 10;
            this.ansRadioButton2.TabStop = true;
            this.ansRadioButton2.UseVisualStyleBackColor = true;
            this.ansRadioButton2.CheckedChanged += new System.EventHandler(this.ansRadioButtonClicked);
            // 
            // ansRadioButton3
            // 
            this.ansRadioButton3.AutoSize = true;
            this.ansRadioButton3.Location = new System.Drawing.Point(560, 371);
            this.ansRadioButton3.Name = "ansRadioButton3";
            this.ansRadioButton3.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton3.TabIndex = 11;
            this.ansRadioButton3.TabStop = true;
            this.ansRadioButton3.UseVisualStyleBackColor = true;
            this.ansRadioButton3.CheckedChanged += new System.EventHandler(this.ansRadioButtonClicked);
            // 
            // ansRadioButton4
            // 
            this.ansRadioButton4.AutoSize = true;
            this.ansRadioButton4.Location = new System.Drawing.Point(560, 408);
            this.ansRadioButton4.Name = "ansRadioButton4";
            this.ansRadioButton4.Size = new System.Drawing.Size(17, 16);
            this.ansRadioButton4.TabIndex = 12;
            this.ansRadioButton4.TabStop = true;
            this.ansRadioButton4.UseVisualStyleBackColor = true;
            this.ansRadioButton4.CheckedChanged += new System.EventHandler(this.ansRadioButtonClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "１";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "２";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "３";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "４";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(665, 318);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(148, 50);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "追加／上書き";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(665, 374);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(148, 50);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "正解にチェック";
            // 
            // QuizListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
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
            this.Controls.Add(this.ans4TextBox);
            this.Controls.Add(this.ans3TextBox);
            this.Controls.Add(this.ans2TextBox);
            this.Controls.Add(this.ans1TextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.quizDataGrid);
            this.Name = "QuizListManager";
            this.Text = "QuizListManager";
            this.CursorChanged += new System.EventHandler(this.QuizDataGrid_SelectionChanged);
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView quizDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 問題文DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢１DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢２DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢３DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 選択肢４DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回答番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource quizDataTableBindingSource;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox ans1TextBox;
        private System.Windows.Forms.TextBox ans2TextBox;
        private System.Windows.Forms.TextBox ans3TextBox;
        private System.Windows.Forms.TextBox ans4TextBox;
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.BindingSource quizDataTableBindingSource1;
        private System.Windows.Forms.Label label7;
    }
}