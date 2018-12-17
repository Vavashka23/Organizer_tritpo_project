using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer;
using Xunit;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [Theory]
        [InlineData("Vavashka23")]
        [InlineData("Kirill-Petrov")]
        [InlineData("KirillPetrov123")]
        public void TestDowloadNotes(string _log)
        {
            var notesRedactor = new NotesRedactor();

            string result = notesRedactor.DownloadNotes(_log);

            Xunit.Assert.NotEqual("", result);
        }

        [Theory]
        [InlineData("Vavashka23")]
        [InlineData("Kirill-Petrov")]
        [InlineData("KirillPetrov123")]
        public void TestGetName(string _log)
        {
            var notesRedactor = new NotesRedactor();

            Image image = notesRedactor.GetFoto(_log);

            Xunit.Assert.IsAssignableFrom<Image>(image);
        }
    }
}
