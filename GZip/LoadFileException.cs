namespace GZip
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// LoadFileException class
    /// </summary>
    [Serializable]
    public sealed class LoadFileException : Exception , ISerializable
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
