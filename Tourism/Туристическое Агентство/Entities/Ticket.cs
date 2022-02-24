using System;
using System.Reflection;

namespace Tourism.Entities
{
    public class Ticket : IEntity
    {
        public Ticket() { }

        public int Id { get; set; }

        public string InitialRoute { get; set; }

        public string FinalRoute { get; set; }

        public int VoucherId { get; set; }

        public string InsertCommand
        {
            get => $"INSERT INTO ticket VALUES (0, \'{InitialRoute}\', \'{FinalRoute}\', {VoucherId})";
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
                    case "InitialRoute":
                        InitialRoute = values[i].ToString();
                        break;
                    case "FinalRoute":
                        FinalRoute = values[i].ToString();
                        break;
                    case "VoucherId":
                        VoucherId = Convert.ToInt32(values[i]);
                        break;
                    default:
                        throw new Exception($"Ошибка записи данных сущности {this.GetType().Name}!");
                }
        }
    }
}
