namespace Relationships.Database.Entities
{
    public class Worker
    {
        public Worker() { }

        public Worker(string firstName, int age, WorkerCard card)
        {
            FirstName = firstName;
            Age = age;
            Card = card;
        }



        public int WorkerId { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

        private WorkerCard Card { get; set; }
    }
}
