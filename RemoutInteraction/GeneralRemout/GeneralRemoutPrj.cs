namespace GeneralRemout
{
    class GeneralRemoutPrj : MarshalByRefObject
    {
        public GeneralRemoutPrj()
        {

        }

        public void SendToSraver(string message)
        {
            Console.WriteLine(message);
        }

        public string ReplyFromSraver()
        {
            return "Это сообщение";
        }
    }
}
