using System;
using System.IO;
using System.Collections.Generic;

using Archive.Exceptions;
using Archive.Documents.Word;
using Archive.Documents.Pdf;

#nullable enable
namespace Archive.Documents
{
    public abstract class TextDocumentInfo
    {
        private readonly FileInfo _documentFileInfo;



        protected TextDocumentInfo(FileInfo documentFileInfo)
        {
            this._documentFileInfo = documentFileInfo;
            KeyWords = Array.Empty<string>();
        }



        /// <summary>
        /// Возвращает описание документа.
        /// </summary>
        public abstract string Summary { get; }

        /// <summary>
        /// Возвращает название документа исходя из названия файла.
        /// </summary>
        public virtual string Title =>
            _documentFileInfo.Name;
        

        /// <summary>
        /// Возвращает номер доумента, указанный в названии файла.
        /// </summary>
        public virtual int Number
        {
            get
            {
                string fileName = _documentFileInfo.Name;
                string strNumber = fileName.Split(new char[] { '.', '\\' })[0];
                bool isDigit = int.TryParse(strNumber, out int number);

                if (isDigit)
                    return number;
                else
                    throw new FileNumberException();
            }
        }

        /// <summary>
        /// Возвращает корректный путь к файлу документа.
        /// </summary>
        public virtual string Path => 
            _documentFileInfo.FullName;

        /// <summary>
        /// Ключевые слова к документу.
        /// </summary>
        public virtual string[] KeyWords { get; set; }

        public abstract string Text { get; }



        /// <summary>
        /// Загружает указанный файл и возвращает объект <see cref="TextDocumentInfo"/>, который хранит информацию о нём.
        /// </summary>
        /// <param name="filename">Путь к файлу, который надо загрузить.</param>
        /// <returns>Готовый объект <see cref="TextDocumentInfo"/>.</returns>
        public static TextDocumentInfo Load(FileInfo documentFileInfo)
        {
            return documentFileInfo.Extension switch
            {
                ".rtf" or 
                ".odt" or 
                ".docx" or 
                ".doc" => new WordDocumentInfo(documentFileInfo),
                ".pdf" => new PdfDocumentInfo(documentFileInfo),
                _ => throw new TextFileFormatException(),
            };
        }
    }
}
