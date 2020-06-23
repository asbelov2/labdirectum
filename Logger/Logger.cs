namespace Logger
{
    using System;
    using System.IO;

    /// <summary>
    /// Логгер - класс для ведения логов.
    /// </summary>
    public class Logger : IDisposable
    {
        /// <summary>
        /// Файл логов.
        /// </summary>
        private FileStream logFile;

        /// <summary>
        /// Писатель в лог.
        /// </summary>
        private StreamWriter logWriter;

        /// <summary>
        /// Flag for Dispose method
        /// </summary>
        private bool disposedValue = false; // Для определения избыточных вызовов

        /// <summary>
        /// Создать объект.
        /// </summary>
        /// <param name="fileName">Имя файла логов.</param>
        public Logger(string fileName)
        {
            this.logFile = new FileStream(fileName, FileMode.Append);
            this.logWriter = new StreamWriter(this.logFile);
        }

        /// <summary>
        /// Write string in log
        /// </summary>
        /// <param name="data">String to write in log</param>
        public void WriteString(string data)
        {
            this.logWriter.WriteLine(data);
        }

        /// <summary>
        /// Public dispose
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        /// <param name="disposing">True for managed objects</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    Console.WriteLine("Resources released");
                    this.logWriter.Dispose();
                    this.logFile.Dispose();
                }

                this.disposedValue = true;
            }
        }
    }
}
