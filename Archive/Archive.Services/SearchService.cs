using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

using Archive.EFCore.Models;

namespace Archive.Services
{
    public class SearchService
    {
        private readonly IEnumerable<Document> _documents;
        private readonly IEqualityComparer<Document> _documentComarer;


        public SearchService()
        {
            _documentComarer = new DocumentComarer();
            _documents = new DbService().GetAllDocuments();
        }


        /// <summary>
        /// Производит поиск по частичному названию документов (название или номер документа без расширения).
        /// </summary>
        /// <returns>Коллекция найденных уникальных документов.</returns>
        public List<Document> SearchByTitle(string searchQuery)
        {
            List<Document> result = new();

            string[] searchAttributes = searchQuery
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (searchAttributes.Length == 1)
                return SearchByAttribute(searchQuery.ToLower());

            for (int i = 0; i < searchAttributes.Length; i++)
            {
                var test = SearchByAttribute(searchAttributes[i].ToLower());
                result = result.Concat(test).ToList();
            }

            return result;
        }

        /// <summary>
        /// Выполняет поиск по ключевым словам среди всех документов.
        /// </summary>
        /// <returns>Коллекция найденных уникальных документов.</returns>
        public List<Document> SearchByKeyWords(string searchQuery)
        {
            string[] keyWords = searchQuery
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.ToLower())
                .ToArray();

            List<Document> result = new();

            for (int i = 0; i < keyWords.Length; i++)
            {
                result = result
                    .Union(_documents.Where(document => document.KeyWords.Split(',').Contains(keyWords[i])))
                    .ToList();
            }

            return result;
        }

        /// <summary>
        /// Производит поиск в документах, выбирая те документы, в которых есть упоминание слов из поискового запроса.
        /// </summary>
        /// <returns>Возвращает коллекцию найденных документов.</returns>
        public List<Document> SearchAtDocumentText(string searchText)
        {
            List<Document> result = new();

            List<Document> storedDocuments = _documents.ToList();

            for (int i = 0; i < storedDocuments.Count; i++)
            {
                if (storedDocuments[i].Text.Contains(searchText))
                {
                   result.Add(storedDocuments[i]);
                }
                else
                {
                    string replaceSpaces = searchText.Replace((char)32, (char)160);
                    if (storedDocuments[i].Text.Contains(replaceSpaces))
                        result.Add(storedDocuments[i]);
                }
            }
            return result;
        }

        private List<Document> SearchByAttribute(string attribute)
        {
            var searchedDocuments = new List<Document>();

            if (int.TryParse(attribute, out int docNum))
                searchedDocuments = _documents
                    .Where(document => document.Number == docNum)
                    .ToList();
            else
                searchedDocuments = _documents
                    .Where(document => document.DocumentTitle
                        .ToLower()
                        .Contains(attribute))
                    .ToList();

            return searchedDocuments;
        }


        private struct DocumentComarer : IEqualityComparer<Document>
        {
            public bool Equals(Document x, Document y)
            {
                return x.Equals(y);
            }

            public int GetHashCode([DisallowNull] Document obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
