namespace LogFilter
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// TextEnumerator class
    /// </summary>
    public class TextEnumerator : IEnumerator<string>
    {
        /// <summary>
        /// Stream for text file
        /// </summary>
        private StreamReader text;

        /// <summary>
        /// Path to text file
        /// </summary>
        private string path;

        /// <summary>
        /// Initializes a new instance of the TextEnumerator class
        /// </summary>
        /// <param name="path">Path to text file</param>
        public TextEnumerator(string path)
        {
            this.path = path;
            try
            {
                this.text = new StreamReader(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.text.Dispose();
            }
        }

        /// <summary>
        /// Gets current string
        /// </summary>
        public string Current { get; private set; }

        /// <summary>
        /// Gets current string
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            this.text.Dispose();
        }

        /// <summary>
        /// Move enumerator to next element
        /// </summary>
        /// <returns> False if text ended, true else</returns>
        public bool MoveNext()
        {
            if (!this.text.EndOfStream)
            {
                this.Current = this.text.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sets enumerator to begin
        /// </summary>
        public void Reset()
        {
            this.text.Close();
            try
            {
                this.text = new StreamReader(this.path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.text.Dispose();
            }
        }
    }
}
