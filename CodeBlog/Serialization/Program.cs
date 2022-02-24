using Serialization;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

List<Group> groups = new();
List<Student> students = new();
for (int i = 1; i < 10; i++)
    groups.Add(new Group(i, "Name " + i));

for (int i = 0; i < 300; i++)
{
    Student student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
    {
        Group = groups[i % 9]
    };
    students.Add(student);
}

// SOAP и Binary - Сериализация проходит всех полей и свойств, даже приватных.
// XML и Json - приватные игнорятся.

//var xml = new XmlSerializer(typeof(List<Student>));
//using FileStream stream = new("students.xml", FileMode.OpenOrCreate);
//xml.Serialize(stream, students);
//stream.Close();

//using FileStream stream2 = new("students.xml", FileMode.Open);
//List<Student> students2 = (List<Student>)xml.Deserialize(stream2);
//stream2.Close();

//foreach (Student s in students2)
//{
//    Console.WriteLine(s.Name);
//}

FileStream jsonStream = new("students.json", FileMode.Create);
var jsonFormat = new DataContractJsonSerializer(typeof(List<Student>));
jsonFormat.WriteObject(jsonStream, students);
jsonStream.Close();

FileStream jsonStreamOut = new("students.json", FileMode.Open);
List<Student> students3 = (List<Student>)jsonFormat.ReadObject(jsonStreamOut);

foreach (Student s in students3)
{
    Console.WriteLine(s.Name);
}
