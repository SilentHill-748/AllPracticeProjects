using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Archive.Documents.Attributes;
using Archive.Documents;

using NUnit.Framework;

namespace Archive.Tests.DocumentsTests
{
    public class ConfigParserTests
    {
        private readonly string _configFilename
            = @"C:\Users\SilentHill\Desktop\Тестовые файлы\Конфиг.txt";
        private DocumentAttributes _docAttrs;


        [SetUp]
        public void Init()
        {
            string[] attrs = new[]
            {
                @"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx",
                "Белка, белки, грызуны",
                "C:\\Users\\SilentHill\\Desktop\\Тестовые файлы\\008.кк рф.rtf," +
                "C:\\Users\\SilentHill\\Desktop\\Тестовые файлы\\009.постановление П-156.docx," +
                "C:\\Users\\SilentHill\\Desktop\\Тестовые файлы\\005.Контакты росприроднадзор.odt"
            };
            _docAttrs = new(attrs);
        }



        [Test]
        public void Init_ConfigParser_Test()
        {
            ConfigParser parser = new(_configFilename);
            int documentCount1 = parser.DocumentCount;

            FileInfo configFile = new(_configFilename);
            ConfigParser parser2 = new(configFile);

            int documentCount2 = parser2.DocumentCount;

            if (documentCount1 != documentCount2)
                Assert.Fail($"Document counters of two different parser objects isn't equal!\nFirst: {documentCount1},\nSecond: {documentCount2}");

            Assert.NotZero(documentCount2);
            Assert.Positive(documentCount2);
            Assert.AreEqual(4, documentCount2);
        }

        [Test]
        public void GetDocumentsWithAttributes_From_ConfigParser_Test()
        {
            ConfigParser parser = new(_configFilename);
            List<DocumentAttributes> list = parser.GetDocumentsWithAttributes();

            DocumentAttributes expected = _docAttrs;

            DocumentAttributes actual = list[0];

            Assert.DoesNotThrow(() => parser.GetDocumentsWithAttributes());

            Assert.IsNotNull(list);
            Assert.IsNotEmpty(list);
            Assert.IsNotNull(actual.RootDocument);
            Assert.IsNotNull(actual.KeyWords);
            Assert.IsNotEmpty(actual.KeyWords);
            Assert.IsNotNull(actual.ReferenceDocuments);
            Assert.IsNotEmpty(actual.ReferenceDocuments);

            CollectionAssert.AreEquivalent(expected.KeyWords, actual.KeyWords);
            StringAssert.AreEqualIgnoringCase(expected.RootDocument.DirectoryName, actual.RootDocument.DirectoryName);
            StringAssert.AreEqualIgnoringCase(expected.RootDocument.Name, actual.RootDocument.Name);
            StringAssert.AreEqualIgnoringCase(expected.RootDocument.Extension, actual.RootDocument.Extension);
            for (int i = 0; i < expected.ReferenceDocuments.Length; i++)
            {
                FileInfo expectedFile = expected.ReferenceDocuments[i];
                FileInfo actualFile = actual.ReferenceDocuments[i];

                Assert.AreEqual(expectedFile.Length, actualFile.Length);
                StringAssert.AreEqualIgnoringCase(expectedFile.Name, actualFile.Name);
                StringAssert.AreEqualIgnoringCase(expectedFile.Extension, actualFile.Extension);
                StringAssert.AreEqualIgnoringCase(expectedFile.DirectoryName, actualFile.DirectoryName);
            }
        }
    }
}
