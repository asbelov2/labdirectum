using System;

namespace MyLib
{
    /// <summary>
    /// Test class
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Initializes a new instance of the Test class
        /// </summary>
        /// <param name="a">String a</param>
        /// <param name="b">String b</param>
        /// <param name="c">String c</param>
        /// <param name="d">String d</param>
        public Test(string a, string b, string c, string d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        /// <summary>
        /// Initializes a new instance of the Test class without parameters
        /// </summary>
        public Test()
        {
            this.A = "A Empty";
            this.B = "B Empty";
            this.C = "C Empty";
            this.D = "D Empty";
        }

        /// <summary>
        /// Gets or sets A
        /// </summary>
        [Obsolete]
        public string A { get; set; }

        /// <summary>
        /// Sets B
        /// </summary>
        public string B
        {
            set
            {
            }
        }

        /// <summary>
        /// Gets C
        /// </summary>
        public string C { get; }

        /// <summary>
        /// Gets or sets D
        /// </summary>
        public string D { get; set; }
    }
}