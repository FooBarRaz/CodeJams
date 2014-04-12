using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestCaseReader
{
    [TestFixture]
    class FileWriterTest
    {
        [Test]
        public void FileWriterWritesFile()
        {
            var filename = "C:\\temp\\testfile.txt";
            var testStrings = new string[10];
            for (int i = 0; i < testStrings.Length; i++)
            {
                testStrings[i] = new Object().GetHashCode().ToString();
            }

            FileWriter.WriteAllLines(filename, testStrings);

            var writtenLines = TestCaseReader.ReadAllLines(filename);
            for (int i = 0; i < writtenLines.Length; i++)
            {
                Assert.That(testStrings[i], Is.EqualTo(writtenLines[i]));
            }

        }
    }
}
