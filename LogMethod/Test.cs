namespace LogMethod
{
    /// <summary>
    /// Test class
    /// </summary>
    public class Test
    {
        /// <summary>
        /// int a
        /// </summary>
        private int a;

        /// <summary>
        /// string b
        /// </summary>
        private string b;

        /// <summary>
        /// Initializes a new instance of the Test class
        /// </summary>
        /// <param name="a">Int a</param>
        /// <param name="b">String b</param>
        /// <param name="c">Int c</param>
        /// <param name="d">String d</param>
        public Test(int a, string b, int c, string d)
        {
            this.a = a;
            this.b = b;
            this.C = c;
            this.D = d;
        }

        /// <summary>
        /// Gets C
        /// </summary>
        public int C { get; }

        /// <summary>
        /// Gets D
        /// </summary>
        public string D { get; }
    }
}
