using System;
using System.Reflection;

namespace Tourism.Entities
{
    public class Client : IEntity
    {
        public Client() { }

        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string FullName { get; set; }

        public decimal Phone { get; set; }

        public int TicketId { get; set; }

        public string InsertCommand
        {
            get => $"INSERT INTO client VALUES (0, \'{Data:yyyy-MM-dd}\', \'{FullName}\', {Phone}, {TicketId});";
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
                    case "FullName":
                        FullName = values[i].ToString();
                        break;
                    case "Phone":
                        Phone = Convert.ToDecimal(values[i]);
                        break;
                    case "TicketId":
                        TicketId = Convert.ToInt32(values[i]);
                        break;
                    default: throw new Exception($"Ошибка записи данных сущности {this.GetType().Name}!");
                }
        }
    }
}
