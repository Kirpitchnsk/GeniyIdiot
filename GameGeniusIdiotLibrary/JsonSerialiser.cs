using Newtonsoft.Json;
namespace GameGeniusIdiotLibrary
{
    public class JsonSerializer<T>
    {
        public string? Serialize(T obj) => JsonConvert.SerializeObject(obj) ?? String.Empty;
        public T? Deserialize(string json) => JsonConvert.DeserializeObject<T>(json);
    }
}
