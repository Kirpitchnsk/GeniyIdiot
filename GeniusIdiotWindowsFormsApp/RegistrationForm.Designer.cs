namespace GeniusIdiotWindowsFormsApp
{
    partial class RegistrationForm
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
            StartButton = new Button();
            label1 = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(118, 298);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(237, 86);
            StartButton.TabIndex = 0;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(475, 33);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать в игру гений-идиот!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 112);
            label2.Name = "label2";
            label2.Size = new Size(335, 33);
            label2.TabIndex = 2;
            label2.Text = "Нам нужно знать ваше имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(118, 181);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(237, 40);
            NameTextBox.TabIndex = 3;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 409);
            Controls.Add(NameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Name = "RegistrationForm";
            Text = "GeniusIdiot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label label1;
        private Label label2;
        private TextBox NameTextBox;
    }
}