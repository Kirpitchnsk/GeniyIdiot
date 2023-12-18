namespace GeniusIdiotWindowsFormsApp
{
    partial class AddQuestion
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
            AddButton = new Button();
            ExitButton = new Button();
            QuestionTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AnswerTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(24, 289);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(163, 78);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(402, 289);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(163, 78);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionTextBox.Location = new Point(39, 88);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(603, 40);
            QuestionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(549, 33);
            label1.TabIndex = 3;
            label1.Text = "Напишите вопрос который желаете добавить";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 154);
            label2.Name = "label2";
            label2.Size = new Size(196, 33);
            label2.TabIndex = 4;
            label2.Text = "И ответ на него";
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerTextBox.Location = new Point(37, 208);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(605, 40);
            AnswerTextBox.TabIndex = 5;
            // 
            // AddQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 450);
            Controls.Add(AnswerTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(QuestionTextBox);
            Controls.Add(ExitButton);
            Controls.Add(AddButton);
            Name = "AddQuestion";
            Text = "AddQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button ExitButton;
        private TextBox QuestionTextBox;
        private Label label1;
        private Label label2;
        private TextBox AnswerTextBox;
    }
}