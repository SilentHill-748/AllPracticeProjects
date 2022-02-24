using System;
using System.IO;

namespace Archive.Documents.Attributes
{
    public struct DocumentAttributes
    {
        public DocumentAttributes(string[] attributes)
        {
            if (attributes.Length == 0)
                throw new ArgumentException($"Empty argument in {typeof(DocumentAttributes).Name}: " + nameof(attributes));

            if (string.IsNullOrWhiteSpace(attributes[0]))
                throw new ArgumentException("First attribute was be empty!");

            RootDocument = new FileInfo(attributes[0]);
            KeyWords = new KeyWordAttribute(attributes[1]).KeyWords;
            ReferenceDocuments = new ReferenceDocumentsAttribute(attributes[2]).ReferenceDocuments;
        }



        public FileInfo RootDocument { get; }

        public string[] KeyWords { get; }

        public FileInfo[] ReferenceDocuments { get; }
    }
}
