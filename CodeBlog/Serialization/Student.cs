using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    public class Student
    {
        [DataMember]
        private int i = 123456789;



        public Student()
        {

        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }


        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public Group Group { get; set; }



        public override string ToString()
        {
            return Name;
        }

        public void PrintI() =>
            Console.WriteLine(i);
    }
}
