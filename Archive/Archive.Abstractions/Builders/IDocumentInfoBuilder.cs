namespace Archive.Abstractions.Builders
{
    using Archive.Abstractions.Documents;

    /// <summary>
    /// Описывает объект, который строит из <see cref="IDocument"/> соответствующий <see cref="IDocumentInfo"/> с информацией о документе.
    /// </summary>
    public interface IDocumentInfoBuilder
    {
        /// <summary>
        /// Построение объекта <see cref="IDocumentInfo"/> из документа <see cref="IDocument"/>.
        /// </summary>
        /// <param name="document">Доумент для выделения основной информации и построения <see cref="IDocumentInfo"/>.</param>
        /// <returns>Готовый к работе <see cref="IDocumentInfo"/>.</returns>
        IDocumentInfo Build(IDocument document);

        /// <summary>
        /// Построение коллекции объектов <see cref="IDocumentInfo"/> из коллекции <see cref="IDocument"/>.
        /// </summary>
        /// <param name="documents">Доументы для выделения основной информации и построения коллекции <see cref="IDocumentInfo"/>.</param>
        /// <returns>Готовую к работе коллекцию объектов <see cref="IDocumentInfo"/>.</returns>
        IDocumentInfo[] Build(IDocument[] documents);
    }
}
