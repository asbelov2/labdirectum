namespace GZip
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Form class
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form
        /// </summary>
        public Form1()
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            this.Decompress("q2.rtf.gz", richTextBox);
            this.Controls.Add(richTextBox);

            this.InitializeComponent();
        }

        /// <summary>
        /// Decopressing .gz RTF in RichTextBox
        /// </summary>
        /// <param name="compressedFile">Path to .gz file</param>
        /// <param name="target">RichTextBox target element</param>
        public void Decompress(string compressedFile, RichTextBox target)
        {
            using (var sourceStream = new FileStream(compressedFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var decompressStream = new GZipStream(sourceStream, CompressionMode.Decompress, true))
            using (var textReader = new StreamReader(decompressStream, true))
            {
                target.Rtf = textReader.ReadToEnd();
            }
        }
    }
}
