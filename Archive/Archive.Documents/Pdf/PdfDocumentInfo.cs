using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using Archive.Exceptions;

using BitMiracle.Docotic.Pdf;

using Tesseract;

namespace Archive.Documents.Pdf
{
    public sealed class PdfDocumentInfo : TextDocumentInfo, IDisposable
    {
        private string _textFromImage;
        private readonly PdfDocument _pdfDocument;
        private bool _disposed;



        internal PdfDocumentInfo(FileInfo pdfFileInfo)
            : base(pdfFileInfo)
        {
            this._textFromImage = string.Empty;
            this._pdfDocument = new(pdfFileInfo.FullName);
            _disposed = false;
        }

        ~PdfDocumentInfo()
        {
            Dispose(false);
        }



        public bool IsScanDocument
        {
            get
            {
                List<PdfImage> imagesFromFirstPage = _pdfDocument
                    .GetPage(0)
                    .GetImages()
                    .ToList();

                if (imagesFromFirstPage.Count > 0)
                {
                    if (string.IsNullOrWhiteSpace(GetTextFromFirstPage()))
                        return true;
                }
                return false;
            }
        }

        public override string Summary =>
            SetupSummary();

        public override string Text
        {
            get
            {
                //if (IsScanDocument)
                //    return SearchTextInScanAtFirstPage();

                return _pdfDocument.GetText();
            }
        }

        /// <summary>
        /// Если документ состоит из скан-скринов, 
        /// то вернет первую страницу такого документа в виде массива байт. 
        /// <para>В остальных случая вернет Null.</para>
        /// </summary>
        public byte[]? FirstPageScreen =>
            LoadScanFromFirstPage();


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _pdfDocument.Dispose();

                _disposed = true;
            }
        }

        // Вывод строкого готового описания из скана первой страницы или текста из страницы, если она не является сканом.
        private string SetupSummary()
        {
            if (IsScanDocument)
            {
                SearchTextInScanAtFirstPage();
                return SelectionSummaryText(_textFromImage);
            }
            else
                return SelectionSummaryText(GetTextFromFirstPage());
        }

        // Строит готовое описание документа из прочитанного текста первой страницы.
        private string SelectionSummaryText(string readedText)
        {
            //TODO: Придумай алгоритм вывода описания из мешанины текста.
            string descriptionText = string.Empty;

            descriptionText = readedText;

            return descriptionText;
        }

        //Поиск текста в изображении скана первой страницы.
        private string SearchTextInScanAtFirstPage()
        {
            byte[] image = FirstPageScreen ?? throw new ImageNotLoadedException();
            try
            {
                TesseractEngine tesseractEngine = new(
                    Directory.GetCurrentDirectory() + @"\tessdata",
                    "rus");

                return tesseractEngine
                        .Process(Pix.LoadFromMemory(image))
                        .GetText();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"At process by reading image in \'WordDocuemtnInfo.GetSummaryFromPageScreen()\' " +
                    $"was throw exception with text:\n{ex.Message}");

                return string.Empty;
            }
        }

        // Выгрузка скана первой страницы из документа в массиве байт.
        private byte[]? LoadScanFromFirstPage()
        {
            byte[]? imageData = default;
            MemoryStream saveImageStream = new();

            if (_pdfDocument.Pages.Count > 0)
            {
                _pdfDocument.Pages[0]
                    .GetImages()
                    .First()
                    .Save(saveImageStream);
                return saveImageStream.ToArray();
            }
            return imageData;
        }

        // Вывод чистого текста из первой страницы документа.
        private string GetTextFromFirstPage()
        {
            if (_pdfDocument.PageCount > 0)
                return _pdfDocument.Pages[0].GetText();
            return string.Empty;
        }
    }
}
