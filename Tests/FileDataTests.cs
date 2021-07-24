using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileData;

namespace Tests
{
    [TestClass]
    public class FileDataTests
    {
        [TestMethod]        
        public void TestVersion()
        {
            IFile file = new File();
            string[] args = { "--Version", "C:/test.txt" };
            var output = file.PrintFileDetails(args);
            Assert.AreNotEqual("Invalid Args", output);
        }

        [TestMethod]
        public void TestSize()
        {
            IFile file = new File();
            string[] args = { "--Size", "C:/test.txt" };
            var output = file.PrintFileDetails(args);
            Assert.AreNotEqual("Invalid Args", output);
        }

        [TestMethod]
        public void TestInvalid()
        {
            IFile file = new File();
            string[] args = { "-test", "C:/test.txt" };
            var output = file.PrintFileDetails(args);
            Assert.AreEqual("Invalid Args", output);
        }
    }
}
