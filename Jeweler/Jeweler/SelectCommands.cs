namespace Jeweler
{
    public static class SelectCommands
    {
        public static string SelectProducts =>
            "SELECT  НазваниеИзделия AS 'Изделие', " +
                    "Название_поставщика AS 'Поставщик', " +
                    "НазваниеТипа AS 'Тип изделия', " +
                    "Колличестово_изделий, " +
                    "Цена, " +
                    "Стоймость_закупа " +
            "FROM Изделия И " +
            "JOIN Типы_изделий Т ON Т.Код_типа_изделия = И.Код_типа_изделия " +
            "JOIN Поставщики П ON П.КодПоставщика = И.КодПоставщика;";

        public static string SelectOrders =>
            "SELECT  НазваниеИзделия AS 'Изделие', " +
                    "Дата_продажи, П.Цена, " +
                    "Размер_скидки, " +
                    "Цена_со_скидкой " +
            "FROM Продажи П " +
            "JOIN Изделия И ON И.Код_изделия = П.Код_изделия;";

        public static string SelectProviders =>
            "SELECT  К.Название AS 'Компания', " +
                    "Название_поставщика " +
            "FROM Поставщики П " +
            "JOIN компании К ON К.КодКомпании = П.КодКомпании;";

        public static string SelectCompanies =>
            "SELECT Название, Адрес, Телефон " +
            "FROM компании;";

        public static string SelectReport =>
            "SELECT * " +
            "FROM report;";
    }
}
