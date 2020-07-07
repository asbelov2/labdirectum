namespace LogFilter
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Text class
    /// </summary>
    public class Text : IEnumerable<string>, IDisposable
    {
        /// <summary>
        /// Stream for text file
        /// </summary>
        private StreamReader streamReader;

        /// <summary>
        /// Path to text file
        /// </summary>
        private string path;

        /// <summary>
        /// Initializes a new instance of the Text class
        /// </summary>
        /// <param name="path">Path to text file</param>
        public Text(string path)
        {
            this.path = path;
            try
            {
                this.streamReader = new StreamReader(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.streamReader.Dispose();
            }
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            this.streamReader.Dispose();
        }

        /// <summary>
        /// Getting text enumerator method
        /// </summary>
        /// <returns>Returns text enumerator</returns>
        public IEnumerator<string> GetEnumerator()
        {
            return new TextEnumerator(this.path);
        }

        /// <summary>
        /// Getting text enumerator method
        /// </summary>
        /// <returns>Returns text enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TextEnumerator(this.path);
        }
    }
}
