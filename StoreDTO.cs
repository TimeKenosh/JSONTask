using System.Collections.Generic;
using Newtonsoft.Json;

namespace Task1
{
    public class StoreDTO
    {
        [JsonProperty("storeId")]
        private int storeId;

        [JsonProperty("storeName")]
        private string storeName;

        [JsonProperty("eBooks")]
        private List<EBooks> eBooks;

        public int GetStoreId()
        {
            return storeId;
        }

        public void SetStoreId(int StoreId)
        {
            storeId = StoreId;
        }

        public string GetStoreName()
        {
            return storeName;
        }

        public void SetStoreName(string StoreName)
        {
            storeName = StoreName;
        }

        public List<EBooks> GetEBooks()
        {
            return eBooks;
        }

        public void SetEBooks(List<EBooks> EBooks)
        {
            eBooks = EBooks;
        }

        public override bool Equals(object obj)
        {
            StoreDTO compared = obj as StoreDTO;
            if (compared == null)
            {
                return false;
            }
            return storeId == compared.storeId && storeName == compared.storeName && eBooks == compared.eBooks;
        }
    }
}
