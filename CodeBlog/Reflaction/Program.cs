using Reflaction;

using System.Reflection;

Photo photo = new("Space");
photo.Path = "space.png";

object[] attributes = typeof(Photo).GetCustomAttributes(true);
foreach (object attribute in attributes)
{
    Console.WriteLine(attribute);
}

foreach (PropertyInfo prop in typeof(Photo).GetProperties())
{
    Console.WriteLine(prop.Name);
}

Type?[] itest = typeof(Photo).GetInterfaces();
