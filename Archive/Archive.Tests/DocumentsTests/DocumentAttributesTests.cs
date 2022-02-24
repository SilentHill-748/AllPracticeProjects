using System.IO;

using NUnit.Framework;

using Archive.Documents.Attributes;

namespace Archive.Tests.DocumentsTests
{
    public class DocumentAttributesTests
    {
        private string[] _fileAttributes;


        [SetUp]
        public void Init()
        {
            _fileAttributes = new string[]
            {
                @"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx",
                "Белка, белки, грызуны",
                @"C:\Users\SilentHill\Desktop\Тестовые файлы\008.кк рф.rtf,C:\Users\SilentHill\Desktop\Тестовые файлы\009.постановление П-156.docx,C:\Users\SilentHill\Desktop\Тестовые файлы\005.Контакты росприроднадзор.odt"
            };
        }



        [Test]
        public void Init_DocumentAttributes_By_StringArray_Of_File_Attributes_Test()
        {
            FileInfo rootFile = new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx");
            FileInfo[] files = new FileInfo[]
            {
                new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\008.кк рф.rtf"),
                new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\009.постановление П-156.docx"),
                new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\005.Контакты росприроднадзор.odt")
            };

            string[] attrs = new[]
            {
                rootFile.FullName,
                "белки,белка,грызуны",
                $"{files[0].FullName}, {files[1].FullName}, {files[2].FullName}"
            };

            DocumentAttributes expected = new(attrs);

            DocumentAttributes actual = new(_fileAttributes);

            StringAssert.AreEqualIgnoringCase(expected.RootDocument.FullName, actual.RootDocument.FullName);
            for (int i = 0; i < expected.ReferenceDocuments.Length; i++)
                StringAssert.AreEqualIgnoringCase(expected.ReferenceDocuments[i].FullName,
                    actual.ReferenceDocuments[i].FullName);
            CollectionAssert.AreEquivalent(expected.KeyWords, actual.KeyWords);
        }

    }
}
