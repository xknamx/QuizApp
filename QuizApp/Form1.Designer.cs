﻿namespace QuizApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1RadioButton = new System.Windows.Forms.RadioButton();
            this.option2RadioButton = new System.Windows.Forms.RadioButton();
            this.option3RadioButton = new System.Windows.Forms.RadioButton();
            this.option4RadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(71, 24);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(43, 15);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option1RadioButton
            // 
            this.option1RadioButton.AutoSize = true;
            this.option1RadioButton.Location = new System.Drawing.Point(98, 67);
            this.option1RadioButton.Name = "option1RadioButton";
            this.option1RadioButton.Size = new System.Drawing.Size(110, 19);
            this.option1RadioButton.TabIndex = 1;
            this.option1RadioButton.TabStop = true;
            this.option1RadioButton.Text = "radioButton1";
            this.option1RadioButton.UseVisualStyleBackColor = true;
            // 
            // option2RadioButton
            // 
            this.option2RadioButton.AutoSize = true;
            this.option2RadioButton.Location = new System.Drawing.Point(98, 105);
            this.option2RadioButton.Name = "option2RadioButton";
            this.option2RadioButton.Size = new System.Drawing.Size(110, 19);
            this.option2RadioButton.TabIndex = 2;
            this.option2RadioButton.TabStop = true;
            this.option2RadioButton.Text = "radioButton1";
            this.option2RadioButton.UseVisualStyleBackColor = true;
            // 
            // option3RadioButton
            // 
            this.option3RadioButton.AutoSize = true;
            this.option3RadioButton.Location = new System.Drawing.Point(98, 145);
            this.option3RadioButton.Name = "option3RadioButton";
            this.option3RadioButton.Size = new System.Drawing.Size(110, 19);
            this.option3RadioButton.TabIndex = 3;
            this.option3RadioButton.TabStop = true;
            this.option3RadioButton.Text = "radioButton1";
            this.option3RadioButton.UseVisualStyleBackColor = true;
            // 
            // option4RadioButton
            // 
            this.option4RadioButton.AutoSize = true;
            this.option4RadioButton.Location = new System.Drawing.Point(98, 184);
            this.option4RadioButton.Name = "option4RadioButton";
            this.option4RadioButton.Size = new System.Drawing.Size(110, 19);
            this.option4RadioButton.TabIndex = 4;
            this.option4RadioButton.TabStop = true;
            this.option4RadioButton.Text = "radioButton1";
            this.option4RadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(74, 234);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(155, 37);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "確認する";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(134, 292);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(22, 15);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "仮";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 354);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.option4RadioButton);
            this.Controls.Add(this.option3RadioButton);
            this.Controls.Add(this.option2RadioButton);
            this.Controls.Add(this.option1RadioButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "クイズアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton option1RadioButton;
        private System.Windows.Forms.RadioButton option2RadioButton;
        private System.Windows.Forms.RadioButton option3RadioButton;
        private System.Windows.Forms.RadioButton option4RadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

