namespace Tests
{
    using Meeting;
    using DataSet;    //Лишний Using.
    using DateAndNumbersFormat;
    using Logger;
    using Rights;
    using GZip;
    using NUnit.Framework;
    using System;
    using System.Windows.Forms;
    using System.IO;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); // Почему мы устанавливаем культуру перед каждым тестом?
        }

        [Test]
        public void EndlessMeetingTest()
        {
            var endlessMeeting = new EndlessMeeting(DateTime.MinValue);   // Не совсем понимаю что тут тестируется.
            Assert.IsNotNull(endlessMeeting);                             // Конструктор в любом случае вернёт объект, если не будет исключения.
            endlessMeeting = new EndlessMeeting(DateTime.MaxValue);       // Null точно не будет.
            Assert.IsNotNull(endlessMeeting);
        }

        [Test]
        [TestCase(TypedMeeting.MeetingType.Session)]
        [TestCase(TypedMeeting.MeetingType.Instruction)]
        [TestCase(TypedMeeting.MeetingType.Call)]
        [TestCase(TypedMeeting.MeetingType.Birthday)]
        public void TypedMeetingTest(TypedMeeting.MeetingType type)
        {
            var typedMeeting = new TypedMeeting(DateTime.Now, DateTime.MaxValue, type);
            Assert.IsNotNull(typedMeeting);   // Лучше уж в таком случае проверять тип созданного объекта.
        }

        [Test]
        public void DataSetTest()
        {
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
            var result = "Table 1\n\tColumn 1\tColumn 2\tColumn 3\n\t1\t2\t3\n\t4\t5\t6\n\t7\t8\t9\nTable 2\n\tColumn 1\tColumn 2\tColumn 3\n\t1\t2\t3\n\t4\t5\t6\n\t7\t8\t9\nTable 3\n\tColumn 1\tColumn 2\tColumn 3\n\t1\t2\t3\n\t4\t5\t6\n\t7\t8\t9\n";
            Assert.AreEqual(DataSet.Program.Method(dataSet, '\t', '\t'), result);
        }

        [Test]
        public void DateFormatTest()
        {
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.OnlyNumbers),
                "08.07.2020");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.OnlyNumbersShort),
                "08.07.20");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.WithWords),
                "08 July 2020");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.WithWordsShort),
                "08 Jul 2020");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.USNumbers),
                "07.08.2020");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.USWords),
                "July 08, 2020");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.ChinaNumber),
                "2020.07.08");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.DateWithTime),
                "Wednesday, July 8, 2020 1:01:01 AM");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.DateWithTimeShort),
                "7/8/2020 1:01:01 AM");
            Assert.AreEqual(
                DateAndNumbersFormat.Program.FormatDate(new DateTime(2020, 7, 8, 1, 1, 1), DateFormatType.OnlyTime),
                "1:01:01 AM");
        }

        [Test]
        [TestCase(NumberFormatType.Dot, 13034634.2352, ExpectedResult = "13034634.2352")]
        [TestCase(NumberFormatType.Exp, 13034634.2352, ExpectedResult = "1.3035E+7")]
        [TestCase(NumberFormatType.Bank, 13034634.2352, ExpectedResult = "13,034,634.235")]
        public string NumberFormatTest(NumberFormatType type, double number)
        {
            return DateAndNumbersFormat.Program.FormatNumber(number, type);
        }

        [Test]
        public void LoggerTest()
        {
            object logref;
            using (Logger log = new Logger("test.txt"))
            {
                logref = log;
                log.WriteString("1");
                log.WriteString("2");
                log.WriteString("3");
            }
            Assert.That(                                  // Такая проверка не нужна. Получается что мы тестируем конструкцию using.
                () => ((Logger)logref).WriteString("4"),  // Лучше проверить содержимое файла.
                Throws.Exception);
        }

        [Test]
        [TestCase(AccessRights.Add | AccessRights.Delete | AccessRights.Edit, ExpectedResult = "Add Edit Delete\r\n")]
        [TestCase(AccessRights.Run | AccessRights.View, ExpectedResult = "View Run \r\n")]
        [TestCase(AccessRights.AccessDenied | AccessRights.Add, ExpectedResult = "Access denied\n")]
        [TestCase(AccessRights.Ratify, ExpectedResult = "Ratify \r\n")]
        public string RigtsTest(AccessRights rights)
        {
            string result = "";
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);     // Супер! Учитывая исходную программу, это хороший варинт проверки.
                Rights.Program.ShowRights(rights);
                result = writer.GetStringBuilder().ToString();
                writer.Flush();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
            return result;
        }

        [Test]
        [TestCase("wrongfile.rtf.gz")]
        [TestCase("")]
        public void GZipOpenToRtfTest(string compressedFile)
        {
            Assert.That(
                () => new Form1().Decompress(compressedFile, new RichTextBox()), 
                Throws.Exception);
        }

        [Test]
        [TestCase("123.rtf.gz")]
        public void GZipCantOpen(string compressedFile)
        {
            Assert.That(
                () => new Form1().Decompress(compressedFile, new RichTextBox()),
                Throws.TypeOf(typeof(LoadFileException)));
        }

        [Test]
        [TestCase("q2.rtf.gz")]
        public void GZipCanOpen(string compressedFile)
        {
            Assert.DoesNotThrow(() => new Form1().Decompress(compressedFile, new RichTextBox()));
        }

    }
}