namespace GameGeniusIdiotLibrary
{
    public class QuestionStorage
    {
        public static List<Question> Questions { get; private set; } = new List<Question>();
        private static readonly List<Question> startQuestions = new()
        {
            new Question("Сколько будет 2+2*2?",6),
            new Question("Пять свечей горело, две потухло, сколько осталось?",2),
            new Question("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?",9),
            new Question("Укол делают каждые полчаса, сколько нужно минут для 3 уколов?",60),
            new Question("Hа двух руках 10 пальцев, сколько пальцев на пяти руках?",25)
        };
        public const string FileName = "question.txt";
        public const string FileNameJson = "question.json";
        public QuestionStorage()
        {
            InitialiseQuestions();
            ShuffleStorage();
        }
        private static void InitialiseQuestions()
        {
            if(FileProvider.IsFileCreated(FileNameJson) && !FileProvider.IsFileEmpty(FileNameJson))
            {
                //var data = FileProvider.GetValue(FileName).Split("\n");
                var serializer = new JsonSerializer<Question>();
                var data = FileProvider.GetValue(FileNameJson).Split("\n");
                foreach (var item in data)
                {
                    if(item != String.Empty)
                    {
                        //var questionItems = item.Split(";");
                        //var question = new Question(questionItems[0], int.Parse(questionItems[1]));
                        var question = serializer.Deserialize(item);
                        Questions.Add(question);
                    }
                }
            }
            else
            {
                foreach (var question in startQuestions)
                {
                    AddData(question);
                }
            }
        }
        private static void ShuffleStorage()
        {
            var rnd = new Random();
            var questions = new List<Question>();
            var indexes = Enumerable.Range(0, Questions.Count).ToArray();
            for (int i = indexes.Length - 1; i > 0; i--)
            {
                int randomIndex = rnd.Next(i + 1);
                (indexes[randomIndex], indexes[i]) = (indexes[i], indexes[randomIndex]);
            }
            for (int i = 0; i < Questions.Count; i++)
            {
                questions.Add(new Question(Questions[indexes[i]].TextValue, Questions[indexes[i]].Answer));
            }
            Questions = questions;
        }
        public static void AddData(Question question)
        {
            var serializer = new JsonSerializer<Question>();
            Questions.Add(question);
            var data = serializer.Serialize(question);
            //var data = $"{question.TextValue};{question.Answer}";
            FileProvider.Append(FileNameJson, data);
        }
        public static void RemoveData(Question question)
        {
            Questions.Remove(question);
            FileProvider.Clear(FileNameJson);
            foreach(var item in Questions)
            {
                var serializer = new JsonSerializer<Question>();
                //var data = $"{item.TextValue};{item.Answer}";
                var data = serializer.Serialize(item);
                //FileProvider.Append(FileName, data);
                FileProvider.Append(FileNameJson, data);
            }
        }
    }
}