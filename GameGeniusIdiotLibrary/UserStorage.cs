namespace GameGeniusIdiotLibrary
{
    public class UserStorage
    {
        public const string FileName = "user.txt";
        public const string FileNameJson = "user.json";
        public static List<User> Users { get; private set; }= new List<User>();
        public UserStorage()
        {
            //GetFromFile();
            GetFromFileJson();
        }
        private static void GetFromFile()
        {
            if (FileProvider.IsFileCreated(FileName) && !FileProvider.IsFileEmpty(FileName))
            {
                var data = FileProvider.GetValue(FileName).Split("\n");
                foreach (var item in data)
                {
                    if (item != String.Empty)
                    {
                        var userItems = item.Split(";");
                        var user = new User(userItems[0], int.Parse(userItems[1]), (Diagnoses)int.Parse(userItems[3]));
                        Users.Add(user);
                    }
                }
            }

        }
        private static void GetFromFileJson()
        {
            var serializer = new JsonSerializer<User>();
            if (FileProvider.IsFileCreated(FileNameJson) && !FileProvider.IsFileEmpty(FileNameJson))
            {
                var jsonData = FileProvider.GetValue(FileNameJson).Split("\n");
                foreach (var item in jsonData)
                {
                    if (item != String.Empty)
                    {
                        var user = serializer.Deserialize(item);
                        Users.Add(user);
                    }
                }
            }
        }
        public static void Add(User user)
        {
            var serializer = new JsonSerializer<User>();
            Users.Add(user);
            //var info = $"{user.Name};{user.CountRightAnswers};{user.Diagnosis};{(int)user.Diagnosis}";
            var jsonInfo = serializer.Serialize(user);
            FileProvider.Append(FileNameJson, jsonInfo);
            //FileProvider.Append(FileName, info);
        }
        public static void Remove(User user)
        {
            Users.Remove(user);
            FileProvider.Clear(FileNameJson);
            var serializer = new JsonSerializer<User>();
            foreach (var item in Users)
            {
                //var data = $"{item.Name};{item.CountRightAnswers};{item.Diagnosis};{(int)item.Diagnosis}";
                var itemJson = serializer.Serialize(item);
                FileProvider.Append(FileNameJson, itemJson);
                //FileProvider.Append(FileName, data);
            }
        }
        public static void Clear() => Users.Clear();
    }
}