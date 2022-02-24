using System.Collections.Generic;
using System.Xml.Serialization;

using Archive.EFCore.Models;

namespace Archive.Tests.DatabaseTests
{
    [XmlRoot("ExpectedDocuments")]
    public class ExpectedDocuments
    {
        [XmlElement("Document")]
        public List<Document> Documents { get; set; }
    }
}
