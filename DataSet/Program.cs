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
        ///  The main entry point for the application.
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dataSet = new System.Data.DataSet();
            dataSet.Tables.Add("Table 1");
            dataSet.Tables.Add("Table 2");
            dataSet.Tables.Add("Table 3");
            foreach (System.Data.DataTable table in dataSet.Tables)
            {
                table.Columns.Add("Column 1");
                table.Columns.Add("Column 2");
                table.Columns.Add("Column 3");
                table.Rows.Add("1", "2", "3");
                table.Rows.Add("4", "5", "6");
                table.Rows.Add("7", "8", "9");
            }
            Console.WriteLine(Method(dataSet, '\t', '\t'));
            Console.ReadLine();
        }

        /// <summary>
        /// Converts DataSet into string
        /// </summary>
        /// <param name="data">DataSet tables</param>
        /// <param name="recordDelimiter">Delimeter for records</param>
        /// <param name="columnDelimiter">Delimiter for header</param>
        /// <returns>Returns all data in one string</returns>
        public static string Method(DataSet data, char recordDelimiter, char columnDelimiter)
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
