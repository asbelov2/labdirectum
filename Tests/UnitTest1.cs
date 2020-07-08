namespace Tests
{
    using Meeting;
    using DataSet;
    using DateAndNumbersFormat;
    using Logger;
    using Rights;
    using GZip;
    using NUnit.Framework;
    using System;
    using System.Windows.Forms;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EndlessMeetingTest()
        {
            var endlessMeeting = new EndlessMeeting(DateTime.MinValue);
            Assert.IsNotNull(endlessMeeting);
            endlessMeeting = new EndlessMeeting(DateTime.MaxValue);
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
            Assert.IsNotNull(typedMeeting);
        }

        [Test]
        [TestCase("wrongfile.rtf.gz")]
        [TestCase("")]
        public void GZipOpenToRtfTest(string compressedFile)
        {
            GZip.Form1 rtfWindow = new Form1();
            RichTextBox richTextBox = new RichTextBox();
            rtfWindow.Controls.Add(richTextBox);
            Assert.Throws<LoadFileException>(() => rtfWindow.Decompress(compressedFile, richTextBox));
        }
    }
}