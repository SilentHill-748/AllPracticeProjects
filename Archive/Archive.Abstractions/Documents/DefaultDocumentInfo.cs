namespace Archive.Abstractions.Documents
{
    using Archive.Abstractions.Builders;

    /// <summary>
    /// Абстрактный класс, описывающий основную информацию об документе.
    /// </summary>
    public abstract class DefaultDocumentInfo //: IDocumentInfo
    {
        /// <summary>
        /// Строит из <see cref="IDocument"/> объекты <see cref="IDocumentInfo"/>.
        /// </summary>
        protected IDocumentInfoBuilder DocumentBuilder { get; }

        /// <summary>
        /// Хранит <see cref="IDocumentInfo"/>, с которым работает данный объект.
        /// </summary>
        protected IDocumentInfo Document { get; }

        //TODO: Реализуй IDocumentInfo.
        // Данный объект необходим для описания всех свойств и данных конкретного документа.
    }
}
