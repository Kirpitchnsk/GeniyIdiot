namespace GameGeniusIdiotLibrary
{
    [Serializable]
    public class Question
    {
        public string TextValue { get; set;}
        public int Answer { get; set; }
        public Question() {}
        public Question(string question, int answer)
        {
            TextValue = question;
            Answer = answer;
        }
    }
}