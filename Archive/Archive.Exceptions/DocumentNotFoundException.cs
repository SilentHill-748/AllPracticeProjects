using System;

namespace Archive.Exceptions
{
    public class DocumentNotFoundException : Exception
    {
        public DocumentNotFoundException()
            : base()
        {
            Message = "Document is not found by specified path!";
        }

        public DocumentNotFoundException(string message)
            : base(message)
        {
            Message = message;
        }



        public override string Message { get; }
    }
}
