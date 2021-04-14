using NUnit.Framework;
using Task1;
using System.Collections.Generic;

namespace Task1Tests
{
    public class Tests
    {
        readonly List<EBooks> ActualBook = GetJSONFile.GetJSONFileLocal().GetEBooks();

        [Test]
        public void isBookPresent()
        {
            var expectedBook = new EBooks("four", "Python", "150$");
            CollectionAssert.Contains(ActualBook, expectedBook, $"Failed to verify that {expectedBook} object is present in the list");
        }

        [Test]
        public void isBookNotPresent()
        {
            var expectedBook = new EBooks("first", "C#", "300$");
            CollectionAssert.DoesNotContain(ActualBook, expectedBook, $"Confirmed that the wrong book {expectedBook} object is present in the list");
        }
    }
}