namespace GameGeniusIdiotLibrary
{
    [Serializable]
    public class User
    {
        public string? Name { get; private set; }
        public int CountRightAnswers { get; private set; }
        public Diagnoses Diagnosis { get; set; }
        public User() {}
        public User(string? name)
        {
            Name = name;
        }
        public User(string? name, int countRightAnswers, Diagnoses diagnosis)
        {
            Name = name;
            CountRightAnswers = countRightAnswers;
            Diagnosis = diagnosis;
        }
        public void AcceptRightAnswer() => CountRightAnswers++;
    }
}