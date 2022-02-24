using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Archive.EFCore.Models
{
    [XmlRoot("ReferenceDocument")]
    public class ReferenceDocument
    {
        [XmlElement("Number")]
        public int RefNumber { get; set; }

        [XmlElement("DocumentTitle")]
        public string Title { get; set; }
        
        [XmlElement("Path")]
        public string Path { get; set; }

        public string Text { get; set; }

        public List<Document> Documents { get; set; }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj is ReferenceDocument another)
            {
                return  another.RefNumber == RefNumber          &&
                        another.Title == Title                  &&
                        another.Text.Equals(Text)         &&
                        another.Path == Path;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RefNumber, Title, Path, Text);
        }
    }
}
