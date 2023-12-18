using GameGeniusIdiotLibrary;
namespace GeniusIdiotWindowsFormsApp
{
    public partial class AddQuestion : Form
    {
        private Question question;
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var questionValue = QuestionTextBox.Text;
            var answer = CheckNumber();
            if (answer == -1) return;
            question = new(questionValue, answer);
            QuestionStorage.AddData(question);
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int CheckNumber()
        {
            int userInputNumber = -1;
            try
            {
                userInputNumber = int.Parse(AnswerTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели неправильное число");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Вы ввели неправильное число");
            }
            return userInputNumber;
        }
    }
}
