namespace GeniusIdiotWindowsFormsApp
{
    partial class ResultsForm
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
            dataGridView1 = new DataGridView();
            Имя = new DataGridViewTextBoxColumn();
            NumberOfCorrect = new DataGridViewTextBoxColumn();
            Diagnosis = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Имя, NumberOfCorrect, Diagnosis });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(669, 482);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // Имя
            // 
            Имя.HeaderText = "Имя";
            Имя.MinimumWidth = 8;
            Имя.Name = "Имя";
            Имя.Width = 150;
            // 
            // NumberOfCorrect
            // 
            NumberOfCorrect.HeaderText = "Количиство правильных ответов";
            NumberOfCorrect.MinimumWidth = 8;
            NumberOfCorrect.Name = "NumberOfCorrect";
            NumberOfCorrect.Width = 150;
            // 
            // Diagnosis
            // 
            Diagnosis.HeaderText = "Диагноз";
            Diagnosis.MinimumWidth = 8;
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(510, 134);
            button1.Name = "button1";
            button1.Size = new Size(158, 42);
            button1.TabIndex = 1;
            button1.Text = "Удалить элемент";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 506);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ResultsForm";
            Text = "Form1";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Имя;
        private DataGridViewTextBoxColumn NumberOfCorrect;
        private DataGridViewTextBoxColumn Diagnosis;
        private Button button1;
    }
}