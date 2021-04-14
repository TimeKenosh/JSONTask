using Newtonsoft.Json;
using System.IO;

namespace Task1
{
    public static class GetJSONFile
    {
        public static StoreDTO GetJSONFileLocal()
        {
            const string PATH = "D:\\jsonFile\\NewTextDocument.json";
            using StreamReader Reader = new StreamReader(PATH);
            string jsonAsString = Reader.ReadToEnd();
            StoreDTO Parsed = JsonConvert.DeserializeObject<StoreDTO>(jsonAsString);
            return Parsed;
        }
    }
}
