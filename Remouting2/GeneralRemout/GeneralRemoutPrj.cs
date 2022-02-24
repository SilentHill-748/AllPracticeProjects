using System;

namespace GeneralRemout
{
    public class GeneralRemoutPrj : MarshalByRefObject
    {
        public GeneralRemoutPrj()
        {

        }

        public void SendToSrevar(string message)
        {
            Console.WriteLine(message);
        }

        public string ReplyFromSreval()
        {
            return "This message";
        }
    }
}
