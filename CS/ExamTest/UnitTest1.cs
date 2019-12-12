using Microsoft.VisualStudio.TestTools.UnitTesting;
using BID.SWE.EXAM.Impl;
using BID.SWE1.Exam.Interfaces;
using System;
using System.IO;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Exercise1Test1()
        {
            CellPrinter cp = new CellPrinter();
            string result = "Cell rot born on 12.12.2019 is alive"; 
            Assert.AreEqual(result, cp.PrintState(true, DateTime.Today, "rot"));
        }
        [TestMethod]
        public void Exercise1Test2()
        {
            CellPrinter cp = new CellPrinter();
            string result = "Cell is on Position X:6 Y:7";
            Assert.AreEqual(result, cp.PrintPostion(6,7));
        }

        [TestMethod]
        public void Exercise2Test1()
        {
            CellNew2 cn2 = new CellNew2();
            int result = 2;
            Assert.AreEqual(result, cn2.Grow());
        }
        // --- Test 2 fehlt

        [TestMethod]
        public void Exercise3Test1()
        {
            MapNew mn = new MapNew();
            string result = "BID-Map";
            Assert.AreEqual(result, mn.GetMapName());
        }
        [TestMethod]
        public void Exercise3Test2()
        {
            MapNew mn = new MapNew();
            float result = 4;
            Assert.AreEqual(result, mn.GetMapSize(2));
        }
        [TestMethod]
        public void Exercise3Test3()
        {
            MapNew mn = new MapNew();
            int result = 3;
            Assert.AreEqual(result, mn.AddNewCells(3));
        }

        //[TestMethod]
        //public void Exercise3Test4()
        //{
        //    object[] arr = { new Laufen(), new Springen() };
        //    Exercise3 ex = new Exercise3();
        //    object[] result = ex.Method2();
        //    CollectionAssert.AreEqual(arr, result);
        //}

        //[TestMethod]
        //public void Exercise4Test1()
        //{
        //    Exercise4 ex = new Exercise4();
        //    String message = "Frohe Weihnachten ";
        //    MemoryStream ms = new MemoryStream();
        //    ms = ex.Method1();
        //    StreamReader reader;
        //    string text = reader.ReadToEnd();
        //    Assert.AreEqual(message, text);
        //}
    }
}
