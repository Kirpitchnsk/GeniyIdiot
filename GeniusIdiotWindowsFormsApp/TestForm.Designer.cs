namespace GeniusIdiotWindowsFormsApp
{
    partial class TestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            QuestionNumLabel = new Label();
            questionTextLabel = new Label();
            answerField = new TextBox();
            menuStrip1 = new MenuStrip();
            Menu = new ToolStripMenuItem();
            GameRestartMenuItem = new ToolStripMenuItem();
            RestartMenuItem = new ToolStripMenuItem();
            addQuestionNenuItem = new ToolStripMenuItem();
            removeItemToolStripMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(110, 255);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(471, 225);
            nextButton.TabIndex = 0;
            nextButton.Text = "Принять";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_Click;
            // 
            // QuestionNumLabel
            // 
            QuestionNumLabel.AutoSize = true;
            QuestionNumLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionNumLabel.Location = new Point(47, 58);
            QuestionNumLabel.Name = "QuestionNumLabel";
            QuestionNumLabel.Size = new Size(83, 33);
            QuestionNumLabel.TabIndex = 1;
            QuestionNumLabel.Text = "label1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextLabel.Location = new Point(47, 140);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(83, 33);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "label2";
            // 
            // answerField
            // 
            answerField.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            answerField.Location = new Point(47, 196);
            answerField.Name = "answerField";
            answerField.Size = new Size(295, 40);
            answerField.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(672, 41);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += MenuStrip1_ItemClicked;
            // 
            // Menu
            // 
            Menu.DropDownItems.AddRange(new ToolStripItem[] { GameRestartMenuItem, RestartMenuItem, addQuestionNenuItem, removeItemToolStripMenuItem, ExitMenuItem });
            Menu.Name = "Menu";
            Menu.Size = new Size(104, 37);
            Menu.Text = "Меню";
            // 
            // GameRestartMenuItem
            // 
            GameRestartMenuItem.Name = "GameRestartMenuItem";
            GameRestartMenuItem.Size = new Size(408, 42);
            GameRestartMenuItem.Text = "Показать результаты игр";
            GameRestartMenuItem.Click += GameRestartMenuItem_Click;
            // 
            // RestartMenuItem
            // 
            RestartMenuItem.Name = "RestartMenuItem";
            RestartMenuItem.Size = new Size(408, 42);
            RestartMenuItem.Text = "Начать заново";
            RestartMenuItem.Click += RestartMenuItem_Click;
            // 
            // addQuestionNenuItem
            // 
            addQuestionNenuItem.Name = "addQuestionNenuItem";
            addQuestionNenuItem.Size = new Size(408, 42);
            addQuestionNenuItem.Text = "Добавить вопрос";
            addQuestionNenuItem.Click += AddQuestionNenuItem_Click;
            // 
            // removeItemToolStripMenuItem
            // 
            removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            removeItemToolStripMenuItem.Size = new Size(408, 42);
            removeItemToolStripMenuItem.Text = "Удалить вопрос";
            removeItemToolStripMenuItem.Click += RemoveItemToolStripMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(408, 42);
            ExitMenuItem.Text = "Выход";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(493, 37);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(63, 33);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "time";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 510);
            Controls.Add(timeLabel);
            Controls.Add(answerField);
            Controls.Add(questionTextLabel);
            Controls.Add(QuestionNumLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TestForm";
            Text = "GeniusIdiot";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label QuestionNumLabel;
        private Label questionTextLabel;
        private TextBox answerField;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu;
        private ToolStripMenuItem GameRestartMenuItem;
        private ToolStripMenuItem RestartMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem addQuestionNenuItem;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
    }
}