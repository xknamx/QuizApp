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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1RadioButton = new System.Windows.Forms.RadioButton();
            this.option2RadioButton = new System.Windows.Forms.RadioButton();
            this.option3RadioButton = new System.Windows.Forms.RadioButton();
            this.option4RadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizManagerViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quizCounter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(50, 50);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(43, 15);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option1RadioButton
            // 
            this.option1RadioButton.AutoSize = true;
            this.option1RadioButton.Location = new System.Drawing.Point(88, 85);
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
            this.option2RadioButton.Location = new System.Drawing.Point(88, 122);
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
            this.option3RadioButton.Location = new System.Drawing.Point(88, 161);
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
            this.option4RadioButton.Location = new System.Drawing.Point(88, 199);
            this.option4RadioButton.Name = "option4RadioButton";
            this.option4RadioButton.Size = new System.Drawing.Size(110, 19);
            this.option4RadioButton.TabIndex = 4;
            this.option4RadioButton.TabStop = true;
            this.option4RadioButton.Text = "radioButton1";
            this.option4RadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(88, 240);
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
            this.resultLabel.Location = new System.Drawing.Point(50, 289);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quizManagerViewMenu,
            this.exitMenu});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // quizManagerViewMenu
            // 
            this.quizManagerViewMenu.Name = "quizManagerViewMenu";
            this.quizManagerViewMenu.Size = new System.Drawing.Size(191, 26);
            this.quizManagerViewMenu.Text = "クイズマネージャー";
            this.quizManagerViewMenu.Click += new System.EventHandler(this.quizManagerViewClicked);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(191, 26);
            this.exitMenu.Text = "終了";
            this.exitMenu.Click += new System.EventHandler(this.ExitMenuClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quizCounter
            // 
            this.quizCounter.AutoSize = true;
            this.quizCounter.Enabled = false;
            this.quizCounter.Location = new System.Drawing.Point(286, 30);
            this.quizCounter.Name = "quizCounter";
            this.quizCounter.Size = new System.Drawing.Size(32, 15);
            this.quizCounter.TabIndex = 8;
            this.quizCounter.Text = "     ";
            this.quizCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(335, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quizCounter);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.option4RadioButton);
            this.Controls.Add(this.option3RadioButton);
            this.Controls.Add(this.option2RadioButton);
            this.Controls.Add(this.option1RadioButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "クイズアプリ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizManagerViewMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label quizCounter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

