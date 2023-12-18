namespace GeniusIdiotWindowsFormsApp
{
    partial class RemoveQuestion
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
            RemoveButton = new Button();
            ExitButton = new Button();
            AnswerTextBox = new TextBox();
            label1 = new Label();
            questions = new Label();
            SuspendLayout();
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(238, 586);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(183, 70);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Удалить";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click_1;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(603, 592);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(163, 64);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click_1;
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerTextBox.Location = new Point(269, 505);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(417, 40);
            AnswerTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(980, 33);
            label1.TabIndex = 3;
            label1.Text = "Вот полный список вопросов. Напишите номер вопроса который хотите удалить.";
            // 
            // questions
            // 
            questions.AutoSize = true;
            questions.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            questions.Location = new Point(78, 85);
            questions.Name = "questions";
            questions.Size = new Size(0, 33);
            questions.TabIndex = 4;
            // 
            // RemoveQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 668);
            Controls.Add(questions);
            Controls.Add(label1);
            Controls.Add(AnswerTextBox);
            Controls.Add(ExitButton);
            Controls.Add(RemoveButton);
            Name = "RemoveQuestion";
            Text = "RemoveQuestion";
            Load += RemoveQuestion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveButton;
        private Button ExitButton;
        private TextBox AnswerTextBox;
        private Label label1;
        private Label questions;
    }
}