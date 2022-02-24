using System;
using System.IO;
using System.Linq;

namespace Archive.Documents.Attributes
{
    internal struct ReferenceDocumentsAttribute
    {
        public ReferenceDocumentsAttribute(string attribute)
        {
            if (string.IsNullOrWhiteSpace(attribute))
                ReferenceDocuments = Array.Empty<FileInfo>();
            else
                ReferenceDocuments = attribute.Split(',')
                    .Select(filename => new FileInfo(filename.Trim()))
                    .ToArray();
        }



        public FileInfo[] ReferenceDocuments { get; }
    }
}
