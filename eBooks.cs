using Newtonsoft.Json;

namespace Task1
{
    public class EBooks
    {

        [JsonProperty("edition")]
        private string Edition;

        [JsonProperty("language")]
        private string Language;

        [JsonProperty("price")]
        private string Price;

        public string GetEdition()
        {
            return Edition;
        }

        public string SetEdition(string Edition)
        {
            return this.Edition = Edition;
        }

        public string GetLanguage()
        {
            return Language;
        }

        public string SetLanguage(string Language)
        {
            return this.Language = Language;
        }

        public string GetPrice()
        {
            return Price;
        }

        public string SetPrice(string Price)
        {
            return this.Price = Price;
        }

        public EBooks(string Edition, string Language, string Price)
        {
            this.Edition = Edition;
            this.Language = Language;
            this.Price = Price;
        }

        public override bool Equals(object obj)
        {
            EBooks compared = obj as EBooks;
            if (compared == null)
            {
                return false;
            }
            return Edition == compared.Edition && Language == compared.Language && Price == compared.Price;
        }

        public override int GetHashCode()
        {
            return Language.GetHashCode();
        }

    }
}

