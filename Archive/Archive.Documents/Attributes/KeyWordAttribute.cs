using System;
using System.Linq;

namespace Archive.Documents.Attributes
{
    internal struct KeyWordAttribute
    {
        public KeyWordAttribute(string attribute)
        {
            if (string.IsNullOrWhiteSpace(attribute))
                KeyWords = Array.Empty<string>();
            else
                KeyWords = attribute.Split(',')
                    .Select(word => word.Trim().ToLower())
                    .ToArray();
        }


        public string[] KeyWords {  get; }
    }
}
