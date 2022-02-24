using System;
using System.Reflection;

namespace Tourism.Entities
{
    public class Hotels : IEntity
    {
        public Hotels() { }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string InsertCommand
        {
            get => $"INSERT INTO hotels VALUES (0, \'{Name}\', {Price})";
        }

        public void SetValues(object[] values)
        {
            PropertyInfo[] properties = this.GetType().GetProperties();

            for (var i = 0; i < values.Length; i++)
                switch (properties[i].Name)
                {
                    case "Id":
                        Id = Convert.ToInt32(values[i]);
                        break;
                    case "Date":
                        Name = values[i].ToString();
                        break;
                    case "FullName":
                        Price = Convert.ToDecimal(values[i]);
                        break;
                    default:
                        throw new Exception($"Ошибка записи данных сущности {this.GetType().Name}!");
                }
        }
    }
}
