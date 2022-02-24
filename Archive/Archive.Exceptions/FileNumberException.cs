using System;

namespace Archive.Exceptions
{
    public class FileNumberException : Exception
    {
        public FileNumberException()
        {
            Message = "Document dosn't have correct number!";
        }

        public FileNumberException(string message)
            :base(message)
        {
            Message = message;
        }



        public override string Message { get; }
    }
}
