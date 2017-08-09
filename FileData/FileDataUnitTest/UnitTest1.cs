using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace FileDataUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCheckVersion() 
        { 
         string[] myarray={"-v","c:/test.txt"};
         string type = myarray[0];
         string filePath = myarray[1];
         TypeFactory _factory = new TypeFactory();
         TypeChecker tc = _factory.getTypeChecker(type);
         string message = tc.getFileInfo(filePath);
         Assert.AreEqual(tc.MethodCalled,"Version");
        }

        [TestMethod]
        public void TestMethodCheckSize() 
        {
            string[] myarray = { "/s", "c:/test.txt" };
            string type = myarray[0];
            string filePath = myarray[1];
            TypeFactory _factory = new TypeFactory();
            TypeChecker tc = _factory.getTypeChecker(type);
            string message = tc.getFileInfo(filePath);
            Assert.AreEqual(tc.MethodCalled, "Size");
        }

        
    }
}
