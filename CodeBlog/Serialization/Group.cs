using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    public class Group
    {
        [DataMember]
        private int i = 123456789;


        public Group() { }

        public Group(int number, string name)
        {
            Number = number;
            Name = name;
        }


        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public string Name { get; set; }



        public override string ToString()
        {
            return $"{Number}. " + Name;
        }

        public void PrintI() =>
            Console.WriteLine(i);
    }
}
