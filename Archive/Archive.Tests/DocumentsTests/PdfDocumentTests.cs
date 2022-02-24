using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Archive.Documents;
using Archive.Documents.Pdf;
using Archive.Exceptions;

using NUnit.Framework;

namespace Archive.Tests.DocumentsTests
{
    public class PdfDocumentTests
    {
        private string _pathToPdfDocument;
        private PdfDocumentInfo _pdfDocument;



        [SetUp]
        public void InitTests()
        {
            _pathToPdfDocument = @"C:\Users\SilentHill\Desktop\Тестовые файлы\003.Приказ 1547.pdf";
            _pdfDocument = (PdfDocumentInfo)TextDocumentInfo.Load(new(_pathToPdfDocument));
        }




        [Test]
        public void Load_Image_Test()
        {
            
        }

        [Test]
        public void PdfDocument_Is_ScanDocument_Test()
        {
            bool expected = true;

            bool actual = _pdfDocument.IsScanDocument;

            Assert.AreEqual(expected, actual);
        }
    }
}
