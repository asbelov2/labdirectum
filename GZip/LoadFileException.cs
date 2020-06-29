namespace GZip
{
    using System;

    public class LoadFileException : Exception
    {
        public LoadFileException(Exception ex) : base(ex.Message)
        {
            this.SourceEx = ex;
        }

        public Exception SourceEx { get; }
    }
}
