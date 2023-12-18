using GameGeniusIdiotLibrary;
namespace GeniusIdiotWindowsFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            FillTable();
        }
        void FillTable()
        {
            foreach (var item in UserStorage.Users)
            {
                dataGridView1.Rows.Add(item.Name, item.CountRightAnswers, item.Diagnosis);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                UserStorage.Remove(UserStorage.Users[dataGridView1.CurrentRow.Index]);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
        }
    }
}
