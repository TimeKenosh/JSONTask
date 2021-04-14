using Newtonsoft.Json;

namespace Task1
{
    public class EBookDTO
    {

        [JsonProperty("edition")]
        private string edition;

        [JsonProperty("language")]
        private string language;

        [JsonProperty("price")]
        private string price;

        public string GetEdition()
        {
            return edition;
        }

        public string SetEdition(string Edition)
        {
            return edition = Edition;
        }

        public string GetLanguage()
        {
            return language;
        }

        public string SetLanguage(string Language)
        {
            return language = Language;
        }

        public string GetPrice()
        {
            return price;
        }

        public string SetPrice(string Price)
        {
            return price = Price;
        }

        public EBookDTO(string Edition, string Language, string Price)
        {
            edition = Edition;
            language = Language;
            price = Price;
        }

        public override bool Equals(object obj)
        {
            EBookDTO compared = obj as EBookDTO;
            if (compared == null)
            {
                return false;
            }
            return edition == compared.edition && language == compared.language && price == compared.price;
        }
    }
}

