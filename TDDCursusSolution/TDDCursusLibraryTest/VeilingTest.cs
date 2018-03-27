using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    /// <summary>
    /// Summary description for VeilingTest
    /// </summary>
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }

        [TestMethod]
        public void GeenBodGedaanDanIsHoogsteBodNul()
        {
            Assert.AreEqual(decimal.Zero,veiling.HoogsteBod);
        }

        [TestMethod]
        public void EersteBodIsHoogsteBod()
        {
            veiling.DoeBod(1000m);
            Assert.AreEqual(1000m, veiling.HoogsteBod);
        }

        [TestMethod]
        public void MeerdeBiedingenDanIsHoogsteBodGelijkAanGrootsteBedrag()
        {
            veiling.DoeBod(100m);
            veiling.DoeBod(150m);
            veiling.DoeBod(200m);
            Assert.AreEqual(200m, veiling.HoogsteBod);
        }

    }
}
