using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestCaseReader
{
    [TestFixture]
    class TestCaseReaderTest
    {
        [Test]
        public void ReadFile()
        {
            
            string[] lines = TestCaseReader.ReadAllLines(@"C:\Users\Raz\Google Drive\Code\Google Code Jam\TestCaseReader\TestCaseReader\TestCaseReader\TestFile.txt");

            Assert.That(lines.Length, Is.EqualTo(4));
            Assert.That(lines[0], Is.EqualTo("First Line"));
            Assert.That(lines[1], Is.EqualTo("Second Line"));
            Assert.That(lines[2], Is.EqualTo(string.Empty));
            Assert.That(lines[3], Is.EqualTo("Fourth Line"));
        }
    }
}
