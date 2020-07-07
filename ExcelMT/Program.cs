namespace ExcelMT
{
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.IO;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// <param name="args">Aruguments of program</param>
        public static void Main(string[] args)
        {
            EarlyBindingMTCreate("MTEB.xlsx");
            LateBindingMTCreate("MTLB.xlsx");
            Console.ReadLine();
        }

        /// <summary>
        /// Creating multiplication table with early binding
        /// </summary>
        /// <param name="name">Name of the file to save</param>
        public static void EarlyBindingMTCreate(string name)
        {
            var excelApp = new Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add(Type.Missing);

            Worksheet worksheet = excelApp.Worksheets[1];

            for (int i = 1; i <= 9; i++)   // Чтобы было прям совсем понятно, можно вынести смещение в переменную или константу, и написать summary.
            { 
                worksheet.Cells[i + 1, 1] = i - 1;
                worksheet.Cells[1, i + 1] = i - 1;
                for (int j = 1; j <= 9; j++)
                {
                    worksheet.Cells[i + 1, j + 1] = i * j;
                }
            }

            excelApp.Application.ActiveWorkbook.SaveAs(
           Path.Combine(Directory.GetCurrentDirectory(), name),
           Type.Missing,
           Type.Missing,
           Type.Missing,
           Type.Missing,
           Type.Missing,
           XlSaveAsAccessMode.xlNoChange,
           Type.Missing,
           Type.Missing,
           Type.Missing,
           Type.Missing,
           Type.Missing);
        }

        /// <summary>
        /// Creating multiplication table with late binding
        /// </summary>
        /// <param name="name">Name of the file to save</param>
        public static void LateBindingMTCreate(string name)
        {
            dynamic excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
            excelApp.Visible = true;
            excelApp.Workbooks.Add(Type.Missing);

            Worksheet worksheet = excelApp.Worksheets[1];
            for (int i = 1; i <= 9; i++)
            {
                worksheet.Cells[i + 1, 1] = i - 1;
                worksheet.Cells[1, i + 1] = i - 1;
                for (int j = 1; j <= 9; j++)
                {
                    worksheet.Cells[i + 1, j + 1] = i * j;
                }
            }

            excelApp.Application.ActiveWorkbook.SaveAs(
               Path.Combine(Directory.GetCurrentDirectory(), name),
               Type.Missing,
               Type.Missing,
               Type.Missing,
               Type.Missing,
               Type.Missing,
               XlSaveAsAccessMode.xlNoChange,
               Type.Missing,
               Type.Missing,
               Type.Missing,
               Type.Missing,
               Type.Missing);
        }
    }
}
