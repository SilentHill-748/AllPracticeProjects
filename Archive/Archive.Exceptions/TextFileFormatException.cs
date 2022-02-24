using System;

namespace Archive.Exceptions
{
    public class TextFileFormatException : Exception
    {
        public TextFileFormatException() 
            : base()
        {
            Message = "File format is not supported!";
        }

        public TextFileFormatException(string message)
            : base(message)
        {
            Message = message;
        }



        public override string Message { get; }
    }
}
