using System;
using System.Reflection;

namespace Tourism.Entities
{
    public class Voucher : IEntity
    {
        public Voucher() { }

        public int Id { get; set; }

        public DateTime Data { get; set; }

        public decimal HotelsId { get; set; }

        public string InsertCommand
        {
            get => $"INSERT INTO voucher VALUES (0, \'{Data:yyyy-MM-dd}\', {HotelsId})";
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
                    case "Data":
                        Data = Convert.ToDateTime(values[i]);
                        break;
                    case "HotelsId":
                        HotelsId = Convert.ToInt32(values[i]);
                        break;
                    default:
                        throw new Exception($"Ошибка записи данных сущности {this.GetType().Name}!");
                }
        }
    }
}
