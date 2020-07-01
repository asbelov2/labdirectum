namespace Reflection
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
        public Test(string a, string b, string c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// Gets or sets A
        /// </summary>
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
    }
}
