using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Archive.EFCore.Models
{
    [XmlRoot("Document")]
    public class Document
    {
        public Document()
        {
            ReferenceDocuments = new List<ReferenceDocument>();
        }



        [XmlElement("Number")]
        public int Number { get; set; }

        [XmlElement("KeyWords")]
        public string KeyWords { get; set; }

        [XmlElement("DocumentTitle")]
        public string DocumentTitle { get; set; }

        public string Summary { get; set; }

        [XmlElement("Path")]
        public string Path { get; set; }

        public string Text { get; set; }

        [XmlArray("ReferenceDocuments")]
        public List<ReferenceDocument> ReferenceDocuments { get; set; }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj is Document anotherDocument)
            {
                bool result =   anotherDocument.Number == Number                &&
                                anotherDocument.KeyWords == KeyWords            &&
                                anotherDocument.DocumentTitle == DocumentTitle  &&
                                anotherDocument.Summary == Summary              &&
                                anotherDocument.Path == Path                    &&
                                anotherDocument.Text.Equals(Text)         &&                   
                                ReferenceDocumentsEquals(anotherDocument.ReferenceDocuments);

                return result;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number, KeyWords, DocumentTitle, Summary, Path, Text);
        }

        private bool ReferenceDocumentsEquals(List<ReferenceDocument> other)
        {
            for (int i = 0; i < ReferenceDocuments.Count; i++)
                if (!ReferenceDocuments[i].Equals(other[i]))
                    return false;
            return true;
        }
    }
}
