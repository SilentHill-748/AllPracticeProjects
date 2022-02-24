using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Archive.Documents;
using Archive.Documents.Attributes;
using Archive.EFCore.Models;

namespace Archive.Services
{
    public delegate void LoadedDocumentHandler(int step);

    public class DocumentBuilder
    {
        private readonly List<ReferenceDocument> _cachedDocuments;


        public DocumentBuilder()
        {
            _cachedDocuments = new List<ReferenceDocument>();
            BuildedDocuments = new List<Document>();
        }



        public List<Document> BuildedDocuments { get; }


        public event LoadedDocumentHandler BuildedDocument;



        /// <summary>
        /// Преобразет коллекцию <see cref="IEnumerable{DocumentAttributes}"/> в список <see cref="List{Document}"/>
        /// </summary>
        /// <param name="documentAttributesCollection">Коллекция атрибутов документов для преобразования</param>
        /// <returns>Готовая к отправке в БД коллекция документов <see cref="Document"/></returns>
        public void FromDocumentAttributes(IEnumerable<DocumentAttributes> documentAttributesCollection)
        {
            foreach (DocumentAttributes attributes in documentAttributesCollection)
            {
                BuildDocument(attributes);
                GC.Collect();
            }
        }

        //Мапит DocumentAttributes в объект Document и возвращает готовый к отправке в БД объект Document.
        private void BuildDocument(DocumentAttributes document)
        {
            TextDocumentInfo textDoc = TextDocumentInfo.Load(document.RootDocument);
            textDoc.KeyWords = document.KeyWords;

            Document doc = ParseTextDocument(textDoc);

            BuildReferenceDocuments(doc, document.ReferenceDocuments);

            BuildedDocuments.Add(doc);
            BuildedDocument?.Invoke(1);
        }

        private void BuildReferenceDocuments(Document root, FileInfo[] referenceFiles)
        {
            for (int i = 0; i < referenceFiles.Length; i++)
            {
                TextDocumentInfo textDoc = TextDocumentInfo.Load(referenceFiles[i]);

                ReferenceDocument cachedDocument = _cachedDocuments.FirstOrDefault(refDoc => refDoc.RefNumber == textDoc.Number);

                if (cachedDocument is not null)
                    root.ReferenceDocuments.Add(cachedDocument);
                else
                {
                    ReferenceDocument doc = new()
                    {
                        Title = textDoc.Title,
                        RefNumber = textDoc.Number,
                        Text = textDoc.Text,
                        Path = textDoc.Path
                    };

                    _cachedDocuments.Add(doc);
                    root.ReferenceDocuments.Add(doc);
                }
            }
        }

        private static Document ParseTextDocument(TextDocumentInfo textDocument)
        {
            Document document = new()
            {
                Number = textDocument.Number,
                DocumentTitle = textDocument.Title,
                KeyWords = string.Join(",", textDocument.KeyWords),
                Path = textDocument.Path,
                Summary = textDocument.Summary,
                Text = textDocument.Text
            };

            return document;
        }
    }
}
