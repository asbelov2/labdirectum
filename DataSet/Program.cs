namespace DataSet
{
    using System;
    using System.Data;
    using System.Text;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  // Если будет время, то лучше продемонстрировать работу метода.
        }

        /// <summary>
        /// Converts DataSet into string
        /// </summary>
        /// <param name="data">DataSet tables</param>
        /// <param name="recordDelimiter">Delimeter for records</param>
        /// <param name="columnDelimiter">Delimiter for header</param>
        /// <returns>Returns all data in one string</returns>
        public string Method(DataSet data, char recordDelimiter, char columnDelimiter)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataTable table in data.Tables)
            {
                result.Append(table.TableName + "\n");

                foreach (DataColumn column in table.Columns)
                {
                    result.Append(columnDelimiter + column.ColumnName);
                }

                result.Append('\n');

                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                    {
                        result.Append(recordDelimiter + cell.ToString());
                    }

                    result.Append('\n');
                }
            }

            return result.ToString();
        }
    }
}
