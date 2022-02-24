namespace Tourism.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Свойство, хранящее строку вставки сущности в БД.
        /// </summary>
        string InsertCommand { get; }

        /// <summary>
        /// Записывает данные из указанного массива в свойства сущности.
        /// </summary>
        void SetValues(object[] values);
    }
}
