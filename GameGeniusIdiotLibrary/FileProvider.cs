using System.Text;

namespace GameGeniusIdiotLibrary
{
    public class FileProvider
    {
        public static void Write(string filename, string data)
        {
            var writer = new StreamWriter(filename, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }
        public static void Append(string filename, string data)
        {
            var writer = new StreamWriter(filename,true,Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }
        public static void AppendJson(string filename, string data) => File.WriteAllText(filename, data);
        public static string GetValue(string filename)
        {
            var reader = new StreamReader(filename);
            var data = reader.ReadToEnd();
            reader.Close();
            return data;
        }
        public static string GetJsonValue(string filename) => File.ReadAllText(filename);
        public static bool IsFileCreated(string filename) => File.Exists(filename);
        public static bool IsFileEmpty(string filename)
        {
            var fileInfo = new FileInfo(filename);
            if (fileInfo.Length == 0)
            {
                return true; // Файл пустой
            }
            return false;
        }
        public static void Clear(string fileName) => File.WriteAllText(fileName, String.Empty);

    }
}
