using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Task1
{
    public class Store
    {
        [JsonProperty("storeId")]
        private int StoreId;

        [JsonProperty("storeName")]
        private string StoreName;

        [JsonProperty("eBooks")]
        private List<EBooks> EBooks;

        public int GetStoreId()
        {
            return StoreId;
        }

        public void SetStoreId(int StoreId)
        {
            this.StoreId = StoreId;
        }

        public string GetStoreName()
        {
            return StoreName;
        }

        public void SetStoreName(string StoreName)
        {
            this.StoreName = StoreName;
        }

        public List<EBooks> GetEBooks()
        {
            return EBooks;
        }

        public void SetEBooks(List<EBooks> EBooks)
        {
            this.EBooks = EBooks;
        }

        public override bool Equals(object obj)
        {
            Store compared = obj as Store;
            if (compared == null)
            {
                return false;
            }
            return StoreId == compared.StoreId && StoreName == compared.StoreName && EBooks == compared.EBooks;
        }

        public override int GetHashCode()
        {
            return EBooks.GetHashCode();
        }
    }
}
