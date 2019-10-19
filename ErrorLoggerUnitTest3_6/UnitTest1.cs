using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Testing_Method_that_Throw_Exeception3_6.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace ErrorLoggerUnitTest3_6
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_setTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }
    }
}