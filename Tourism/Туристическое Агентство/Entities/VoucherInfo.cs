using System;
using System.Reflection;

namespace Tourism.Entities
{
    public class VoucherInfo : IEntity
    {
        public VoucherInfo() { }

        public DateTime Date { get; set; }

        public string FullName { get; set; }

        public decimal Phone { get; set; }

        public string BeginRoute { get; set; }

        public string FinalRoute { get; set; }

        public DateTime DateOfShipment { get; set; }

        public string Hotel { get; set; }

        public decimal HotelPrice { get; set; }

        public string InsertCommand => null;

        public void SetValues(object[] values)
        {
            PropertyInfo[] properties = this.GetType().GetProperties();

            for (var i = 0; i < values.Length; i++)
                switch (properties[i].Name)
                {
                    case "Date":
                        Date = Convert.ToDateTime(values[i]);
                        break;
                    case "FullName":
                        FullName = values[i].ToString();
                        break;
                    case "Phone":
                        Phone = Convert.ToDecimal(values[i]);
                        break;
                    case "BeginRoute":
                        BeginRoute = values[i].ToString();
                        break;
                    case "FinalRoute":
                        FinalRoute = values[i].ToString();
                        break;
                    case "DateOfShipment":
                        DateOfShipment = Convert.ToDateTime(values[i]);
                        break;
                    case "Hotel":
                        Hotel = values[i].ToString();
                        break;
                    case "HotelPrice":
                        HotelPrice = Convert.ToDecimal(values[i]);
                        break;
                    default:
                        throw new Exception($"Ошибка записи данных сущности {this.GetType().Name}!");
                }
        }
    }
}
