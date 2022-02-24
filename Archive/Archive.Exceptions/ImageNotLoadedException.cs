using System;

namespace Archive.Exceptions
{
    public class ImageNotLoadedException : Exception
    {
        public ImageNotLoadedException() : base()
        {
            Message = "Image can't be loaded, because first page has not have image or image are not conteined text!";
        }

        public ImageNotLoadedException(string message)
            : base(message)
        {
            Message = message;
        }



        public override string Message { get; }
    }
}
