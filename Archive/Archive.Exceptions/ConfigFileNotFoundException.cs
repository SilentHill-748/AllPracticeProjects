using System;

namespace Archive.Exceptions
{
    public class ConfigFileNotFoundException : Exception
    {
        public ConfigFileNotFoundException()
        {
            Message = "Configuration file is not found by specified path!";
        }

        public ConfigFileNotFoundException(string message)
            : base(message)
        {
            Message = message;
        }



        public override string Message {  get; }
    }
}
