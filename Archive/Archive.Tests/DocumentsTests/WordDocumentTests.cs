using System;
using System.IO;

using Archive.Documents;
using Archive.Documents.Word;
using Archive.Exceptions;

using NUnit.Framework;

namespace Archive.Tests.DocumentsTests
{
    public class WordDocumentTests
    {
        private string _pathToWordFile;
        private WordDocumentInfo _wordDocument;
        private string _text;



        [SetUp]
        public void InitialTestsData()
        {
            this._pathToWordFile = @"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx";
            this._text = "Бе́лки - род грызунов семейства беличьих. Кроме собственно рода Sciurus, " +
                "белками называют ещё целый ряд представителей семейства беличьих из родов красные белки " +
                "(Tamiasciurus), пальмовые белки (Funambulus) и многих других. Что касается собственно рода " +
                "Sciurus, то он объединяет в себя около 30 видов, распространённых в Европе, Северной и Южной " +
                "Америке и в умеренном поясе Азии.";
            FileInfo file = new(_pathToWordFile);
            this._wordDocument = TextDocumentInfo.Load(file) as WordDocumentInfo;
        }


        [Test]
        public void Should_Get_New_WordDocument_Test()
        {
            FileInfo file = new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\007.админ регламент 297.rtf");
            FileInfo file2 = new(@"C:\Users\SilentHill\Desktop\Теория для учёбы\doc146353075_620435412.pdf");
            new WordDocumentInfo(file);
            new WordDocumentInfo(file2);
        }

        [Test]
        public void Get_Number_Of_Loaded_TextDocument()
        {
            int expected = 1;
            int actual = _wordDocument.Number;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Throw_DocumentNotFoundException_By_Wrong_Path_Test()
        {
            // Тестирование процесса инициализации TextDocument по указанному некорректному пути к файлу.
            Assert.Throws<ArgumentException>(() =>
                TextDocumentInfo.Load(new("")));

            Assert.Throws<TextFileFormatException>(() =>
                TextDocumentInfo.Load(new("d:\\")));

            Assert.DoesNotThrow(() =>
                TextDocumentInfo.Load(new(@"C:\Users\SilentHill\Desktop\Тестовые файлы\001.Белка.docx")));
        }

        [Test]
        public void Get_Summary_From_TextDocument_Test()
        {
            string expected = _text;
            string actual = _wordDocument.Summary.Trim();

            string message = $"Expected text is'n less that actual.\nExpected length: {_text.Length}\nBut was: {actual.Length}.";
            Assert.LessOrEqual(expected.Length, actual.Length, message);
        }

        [Test]
        public void Get_Title_Of_TextDocument_Test()
        {
            string expected = "001.Белка.docx";

            string actual = _wordDocument.Title;

            StringAssert.AreEqualIgnoringCase(expected, actual);
        }

        [Test]
        public void Path_Property_Is_Actual_Value_In_WordDocument_Test()
        {
            string expected = _pathToWordFile;
            string actual = _wordDocument.Path;

            StringAssert.AreEqualIgnoringCase(expected, actual);
        }
    }
}
