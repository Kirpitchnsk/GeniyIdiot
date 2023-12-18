using GameGeniusIdiotLibrary;
namespace GeniusIdiotWindowsFormsApp
{
    public partial class TestForm : Form
    {
        private bool gameStart;
        private int questionCounter;
        private int countQuestions;
        private List<Question>? questions;
        private Question? currentQuestion;
        private QuestionStorage? questionStorage;
        private readonly User? user;
        private UserStorage? userStorage;
        private RegistrationForm? registrationForm;
        private ResultsForm? resultsForm;
        private AddQuestion? addQuestion;
        private RemoveQuestion? removeQuestion;
        private int minutes = 0;
        private int seconds = 0;
        public TestForm(string username)
        {
            InitializeComponent();
            user = new(username);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            registrationForm = new RegistrationForm();
            resultsForm = new ResultsForm();
            removeQuestion = new RemoveQuestion();
            addQuestion = new();
            questionCounter = 0;
            gameStart = true;
            questionStorage = new QuestionStorage();
            userStorage = new UserStorage();
            questions = QuestionStorage.Questions;
            countQuestions = questions.Count;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            timeLabel.Text = "0:10";
            timer1.Start();
            minutes = 0;
            seconds = 10;
            answerField.Text = String.Empty;
            QuestionNumLabel.Text = $"Вопрос номер {questionCounter + 1}";
            currentQuestion = questions[questionCounter];
            questionTextLabel.Text = currentQuestion.TextValue;
            nextButton.Text = "Следущий вопрос";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = 0;
            var data = answerField.Text;
            if (!InputValidator.CheckNumber(data, out userAnswer)) { MessageBox.Show("Введите корректное число"); return; }
            if (userAnswer == currentQuestion.Answer) user.AcceptRightAnswer();
            questionCounter++;
            if(questionCounter == countQuestions) gameStart = false;
            if (gameStart) ShowNextQuestion();
            else GameEnd();
        }

        private void GameEnd()
        {
            user.Diagnosis = DiagnoseCaluculator.GetDiagnosis(user.CountRightAnswers, countQuestions);
            MessageBox.Show($"{user.Name},вы {user.Diagnosis}");
            UserStorage.Add(user);
            timer1.Stop();
        }

        private void RestartMenuItem_Click(object sender, EventArgs e) => Application.Restart();


        private void ExitMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void GameRestartMenuItem_Click(object sender, EventArgs e)
        {
            if (resultsForm.ShowDialog() == DialogResult.OK) { }
        }

        private void AddQuestionNenuItem_Click(object sender, EventArgs e)
        {
            if (addQuestion.ShowDialog() == DialogResult.OK) { }
        }

        private void RemoveItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (removeQuestion.ShowDialog() == DialogResult.OK) { }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds < 0)
            {
                timer1.Stop();
                questionCounter++;
                if (questionCounter == QuestionStorage.Questions.Count) GameEnd();
                else ShowNextQuestion();
            }
            timeLabel.Text = minutes + ":" + (seconds < 10 ? "0" : "") + seconds;
        }
    }
}