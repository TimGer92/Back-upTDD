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
        [TestMethod]
        public void GeenBodGedaanDanIsHoogsteBodNul()
        {
            var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero,veiling.HoogsteBod);
        }

        [TestMethod]
        public void EersteBodIsHoogsteBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(1000m);
            Assert.AreEqual(1000m, veiling.HoogsteBod);
        }

        [TestMethod]
        public void MeerdeBiedingenDanIsHoogsteBodGelijkAanGrootsteBedrag()
        {
            var veiling = new Veiling();
            veiling.DoeBod(100m);
            veiling.DoeBod(150m);
            veiling.DoeBod(200m);
            Assert.AreEqual(200m, veiling.HoogsteBod);
        }

    }
}
