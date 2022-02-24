using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Reflection;

using NUnit.Framework;

using Archive.EFCore.Models;
using Archive.Services;
using Archive.Documents;
using Archive.Documents.Attributes;

namespace Archive.Tests.DatabaseTests
{
    internal class DocumentBuilderTests
    {
        private DocumentBuilder _documentBuilder;


        [SetUp]
        public void Init()
        {
            _documentBuilder = new DocumentBuilder();
        }



        [Test]
        public void Build_DocumentList_Test()
        {
            ConfigParser parser = new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\Конфиг.txt");
            List<DocumentAttributes> documentAttributesCollection = parser.GetDocumentsWithAttributes();
            _documentBuilder.FromDocumentAttributes(documentAttributesCollection);

            var actual = _documentBuilder.BuildedDocuments
                .OrderBy(document => document.Number)
                .ToList();

            var expected = GetExpectedDocuments()
                .OrderBy(document => document.Number)
                .ToList();

            for (int i = 0; i < expected.Count; i++)
            {
                if (!Equal<Document>(expected[i], actual[i]))
                    Assert.Fail("Root documents isn't equals!");

                for (int l = 0; l < expected[i].ReferenceDocuments.Count; l++)
                {
                    ReferenceDocument expectedRefDoc = expected[i].ReferenceDocuments[l];
                    ReferenceDocument actualRefDoc = actual[i].ReferenceDocuments[l];

                    if (!Equal<ReferenceDocument>(expectedRefDoc, actualRefDoc))
                        Assert.Fail("Reference documents isn't equals! {0} and {1} not equal!", expectedRefDoc, actualRefDoc);
                }
            }

            ReferenceDocument doc1 = actual[0].ReferenceDocuments[2];
            ReferenceDocument doc2 = actual[1].ReferenceDocuments[0];

            Assert.IsTrue(object.ReferenceEquals(doc1, doc2));
        }

        private static List<Document> GetExpectedDocuments()
        {
            string expectedDocumentsPath = @"D:\Кодинг\Проекты C# (VS Community)\Практика и уроки\Archive\Archive.Tests\DatabaseTests\ExpectedDocuments.xml";

            FileStream stream = File.OpenRead(expectedDocumentsPath);

            XmlSerializer xmlSerializer = new(typeof(ExpectedDocuments));

            ExpectedDocuments doc = xmlSerializer.Deserialize(stream) as ExpectedDocuments;

            return doc.Documents;
        }

        private static bool Equal<T>(object d1, object d2)
        {
            PropertyInfo[] propertiesFirst = d1.GetType().GetProperties();
            PropertyInfo[] propertiesSecond = d2.GetType().GetProperties();

            for (int i = 0; i < propertiesFirst.Length - 2; i++)
                if (propertiesFirst[i].Name is not "Text" and not "Summary")
                    if (!propertiesFirst[i].GetValue(d1).Equals(propertiesSecond[i].GetValue(d2)))
                        return false;

            return true;
        }
    }
}
