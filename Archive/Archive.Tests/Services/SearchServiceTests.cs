using System.Collections.Generic;

using NUnit.Framework;

using Archive.Services;
using Archive.EFCore.Models;
using System.Linq;

namespace Archive.Tests.Services
{
    public class SearchServiceTests
    {
        private SearchService _searchService;


        [SetUp]
        public void Init()
        {
            _searchService = new();
        }

        [Test]
        public void SearchByTitle_Test()
        {
            var expected = new List<Document>()
            {
                new Document() 
                { 
                    DocumentTitle = "002.Калан.odt", 
                    KeyWords = "калан,бобр", 
                    Number = 2, 
                    Path = @"C:\Users\SilentHill\Desktop\Тестовые файлы\002.Калан.odt" 
                },
                new Document() 
                { 
                    DocumentTitle = "012.Медведь.rtf", 
                    KeyWords = "медведи,млекопитающие,хищники",
                    Number = 12, 
                    Path = @"C:\Users\SilentHill\Desktop\Тестовые файлы\012.Медведь.rtf" 
                }
            };

            var actual = _searchService.SearchByTitle("Калан, 012");

            if (!EqualsDocuments(expected, actual))
                Assert.Fail("Expected collection aren't equals with actual collection!");
        }

        [Test]
        public void SearchByKeyWords_Test()
        {
            var expected = new List<Document>()
            {
                new Document()
                {
                    DocumentTitle = "012.Медведь.rtf",
                    KeyWords = "медведи,млекопитающие,хищники",
                    Number = 12,
                    Path = @"C:\Users\SilentHill\Desktop\Тестовые файлы\012.Медведь.rtf"
                },
                new Document()
                {
                    DocumentTitle = "001.Белка.docx",
                    KeyWords = "белка,белки,грызуны",
                    Number = 1,
                    Path = @"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx"
                }
            };

            var actual = _searchService.SearchByKeyWords("Млекопитающие, грызуны, белки");

            if (!EqualsDocuments(expected, actual))
                Assert.Fail("Expected collection aren't equals with actual collection!");
        }

        [Test]
        public void Return_Finded_Document_By_Full_Search_Query_Test()
        {
            string searchRequest = "белками называют";

            Document expected = new()
            {
                DocumentTitle = "001.Белка.docx",
                KeyWords = "белка,белки,грызуны",
                Number = 1,
                Path = @"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx"
            };

            List<Document> documents = _searchService.SearchAtDocumentText(searchRequest);

            Document actual = documents.FirstOrDefault();
            actual.ReferenceDocuments = new List<ReferenceDocument>();
            actual.Text = null;
            actual.Summary = null;

            Assert.NotNull(actual);

            if (!expected.Equals(actual))
                Assert.Fail("Expected document isn't equals with actual!");
        }

        private static bool EqualsDocuments(List<Document> col1, List<Document> col2)
        {
            if (col1.Count != col2.Count)
                return false;

            for (int i = 0; i < col1.Count; i++)
            {
                bool result = col1[i].DocumentTitle == col2[i].DocumentTitle &&
                    col1[i].KeyWords == col2[i].KeyWords &&
                    col1[i].Number == col2[i].Number &&
                    col1[i].Path == col2[i].Path;

                if (!result)
                    return false;
            }

            return true;
        }
    }
}
