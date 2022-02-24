namespace Archive.Abstractions.Documents
{
    public interface IDocument
    {
        /// <summary>
        /// Уникальный номер документа.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Заголовок документа.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Тип документа
        /// </summary>
        DocumentType DocumentType { get; }
    }
}
