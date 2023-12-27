using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V12.Lib;

namespace Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoad()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\Test.csv";
            string[,] wait = new string[,] { {"1","i9-14900K","RTX 3090"},
                {"2","i9-14900KF","RTX 3080" }, { "3","i9-14900K","RTX 3070"}};
            string[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
