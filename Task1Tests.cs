using NUnit.Framework;
using Task1;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System;

namespace Task1Tests
{
    public class Tests
    {
        public Store GetJSONFile()
        {
            const string PATH = "D:\\jsonFile\\NewTextDocument.json";
            using StreamReader Reader = new StreamReader(PATH);
            string AllText = Reader.ReadToEnd();
            Store Parsed = JsonConvert.DeserializeObject<Store>(AllText);
            return Parsed;

        }

        [Test]
        public void CheckID()
        {
            Store Parsed = new Store();
            Parsed = GetJSONFile();
            int expectedID = 1;
            int actualID = Parsed.GetStoreId();
            Assert.AreEqual(actualID, expectedID, $"Verification {expectedID} not Euqal with {actualID}");
        }

        [Test]
        public void CheckName()
        {
            Store Parsed = GetJSONFile();
            string expectedName = "Amazon";
            string actualName = Parsed.GetStoreName();
            Assert.AreEqual(actualName, expectedName, $"Verification {expectedName} not Euqal with {actualName}");
        }

        [Test]
        public void CheckTheBook()
        {
            var expectedBook = new EBooks("four", "Python", "150$");
            var actualBook = GetJSONFile().GetEBooks();
            CollectionAssert.Contains(actualBook, expectedBook, $"Verification {expectedBook} not Euqal with {actualBook}");
        }
    }
}