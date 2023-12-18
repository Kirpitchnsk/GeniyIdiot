using GameGeniusIdiotLibrary;
namespace GeniusIdiotWindowsFormsApp
{
    public partial class RemoveQuestion : Form
    {
        public RemoveQuestion() => InitializeComponent();
        private void ExitButton_Click_1(object sender, EventArgs e) => Close();
        private string printQuestions()
        {
            int i = 1;
            var str = String.Empty;
            foreach (var item in QuestionStorage.Questions)
            {
                str += i.ToString() + "." + item.TextValue + "\n";
                i++;
            }
            return str;
        }
        private void RemoveQuestion_Load(object sender, EventArgs e) => label1.Text = printQuestions();

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            var answer = 0;
            var data = AnswerTextBox.Text;
            if (!InputValidator.CheckNumber(data, out answer)) { MessageBox.Show("Введите корректное число"); return; }
            if (answer <= 0 || answer > QuestionStorage.Questions.Count) { MessageBox.Show("введите корректный номер вопроса"); return; }
            QuestionStorage.RemoveData(QuestionStorage.Questions[answer - 1]);
            Close();
        }
    }
}
