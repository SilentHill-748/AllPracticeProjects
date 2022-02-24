using System.Collections.Generic;
using System.Linq;
using System;

using Archive.EFCore;
using Archive.EFCore.Models;
using Archive.Exceptions;

using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Archive.Services
{
    public class DbService
    {
        private readonly IDbContextFactory<ArchiveContext> _dbContextFactory;

        public DbService()
        {
            _dbContextFactory = new ArchiveContextFactory();
        }


        /// <summary>
        /// Добавляет все найденные файлы из файла конфигурации в БД.
        /// </summary>
        /// <param name="counter">Удаленный счетчик</param>
        public void AddDocuments(IEnumerable<Document> documents)
        {
            if (documents is null)
                throw new ArgumentNullException(nameof(documents));

            if (!documents.Any())
                return;

            using ArchiveContext archiveContext = _dbContextFactory.CreateDbContext();

            List<Document> addedDocuments = documents.ToList();

            for (int i = 0; i < addedDocuments.Count; i++)
            {
                Document existedDocument = archiveContext.Documents
                    .Include(document => document.ReferenceDocuments)
                    .Where(document => document.Number == addedDocuments[i].Number)
                    .FirstOrDefault();

                if (existedDocument is null)
                    archiveContext.Documents.Add(addedDocuments[i]);
            }

            archiveContext.SaveChanges();
        }

        /// <summary>
        /// Добавляет указанный документ в базу данных приложения.
        /// </summary>
        /// <param name="document">Добавляемый документ</param>
        /// <exception cref="ArgumentNullException"/>
        public void AddDocument(Document document)
        {
            if (document is null)
                throw new ArgumentNullException(nameof(document));

            using ArchiveContext archiveContext = _dbContextFactory.CreateDbContext();

            if (!archiveContext.Documents.Contains(document))
            {
                archiveContext.Documents.Add(document);
                archiveContext.SaveChanges();
            }
        }

        public void UpdateRange(IEnumerable<Document> documents)
        {
            if (documents is null)
                throw new ArgumentNullException(nameof(documents));

            if (!documents.Any())
                return;

            using ArchiveContext archiveContext = _dbContextFactory.CreateDbContext();

            List<Document> updatedDocuments = documents.OrderBy(document => document.Number).ToList();
            List<Document> storedDocuments = archiveContext.Documents
                .Include(document => document.ReferenceDocuments)
                .ToList();

            for (int i = 0; i < storedDocuments.Count; i++)
            {
                UpdateProperties(storedDocuments[i], updatedDocuments[i]);

                for (int j = 0; j < storedDocuments[i].ReferenceDocuments.Count; j++)
                {
                    ReferenceDocument storedDocument = storedDocuments[i].ReferenceDocuments[j];
                    ReferenceDocument updatedDocument = updatedDocuments[i].ReferenceDocuments[j];

                    UpdateProperties(storedDocument, updatedDocument);
                }
            }

            archiveContext.SaveChanges();
        }

        /// <summary>
        /// Возвращает список всех документов, а также связные с ними документы.
        /// </summary>
        /// <returns>Список всех документов из базы данных.</returns>
        public List<Document> GetAllDocuments()
        {
            using ArchiveContext archiveContext = _dbContextFactory.CreateDbContext();

            if (!archiveContext.Documents.Any())
                return new List<Document>();

            archiveContext.Documents.Load();

            var documents = archiveContext.Documents
                .Include(document => document.ReferenceDocuments)
                .ToList();

            return documents;
        }

        public async Task<List<Document>> GetAllDocumentsAsync()
        {
            using ArchiveContext context = _dbContextFactory.CreateDbContext();

            return await context.Documents
                .Include(document => document.ReferenceDocuments)
                .ToListAsync();
        }

        /// <summary>
        /// Выполняет поиск документов по заданному предикату.
        /// </summary>
        /// <param name="predicate">Условие выбора</param>
        /// <returns>Коллекция найденных документов</returns>
        /// <exception cref="DocumentNotFoundException"></exception>
        public Document GetDocument(Func<Document, bool> predicate)
        {
            using ArchiveContext archiveContext = _dbContextFactory.CreateDbContext();

            Document document = archiveContext.Documents
                .Include(document => document.ReferenceDocuments)
                .FirstOrDefault(predicate);

            if (document == null)
                throw new DocumentNotFoundException("Document not found in database!");

            return document;
        }

        private void UpdateProperties<T>(T storedEntity, T updatedEntity)
            where T : class
        {
            var newProperties = updatedEntity.GetType().GetProperties();
            var oldProperties = storedEntity.GetType().GetProperties();

            for (int j = 1; j < oldProperties.Length - 1; j++)
                oldProperties[j].SetValue(storedEntity, newProperties[j].GetValue(updatedEntity));
        }
    }
}
