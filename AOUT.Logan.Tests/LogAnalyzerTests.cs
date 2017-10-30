using LogAn;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOUT.Logan.Tests
{
    [TestFixture]
    class LogAnalyzerTests
    {

        private LogAnalyzer m_analyzer = null;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidLogFileName_validFileLowerCased_ReturnsTrue()
        {
            

            bool result = m_analyzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result, "filename should be valid");

        }


        [Test]
        public void IsValidLogFileName_validFileUpperCased_ReturnsTrue()
        {


            bool result = m_analyzer.IsValidLogFileName("whatever.SLF");

            Assert.IsTrue(result, "filename should be valid");

        }

        [Test]
        
        public void IsValidLogFileName_EmptyFileName_ThrowsException()
        {
           
            Assert.Throws<ArgumentException>(()=>m_analyzer.IsValidLogFileName(string.Empty));
           

        }

        [Test]
        public void IsValidLogFileName_ValidName_RemembersTrue()
        {
            m_analyzer.IsValidLogFileName("somefile.slf");
            Assert.IsTrue(m_analyzer.WasLastFileNameValid);
        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }
    }
}
