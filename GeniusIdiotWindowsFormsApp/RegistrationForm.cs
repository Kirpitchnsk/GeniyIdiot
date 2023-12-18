namespace GeniusIdiotWindowsFormsApp
{
    public partial class RegistrationForm : Form
    {
        public string userName;
        private TestForm form;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            userName = NameTextBox.Text;
            form = new TestForm(userName);
            form.ShowDialog();
            Close();
        }
    }
}
