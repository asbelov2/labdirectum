namespace GZip
{
    using System;

    /// <summary>
    /// LoadFileException class
    /// </summary>
    public class LoadFileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the LoadFileException class
        /// </summary>
        /// <param name="sourceException">Source exception</param>
        public LoadFileException(Exception sourceException) : base(sourceException.Message)
        {
            this.SourceEx = sourceException;
        }

        /// <summary>
        /// Gets source exception
        /// </summary>
        public Exception SourceEx { get; }
    }
}
