using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{

    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void LepelIsPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());            
        }

        [TestMethod]
        public void AppelIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("appel").IsPalindroom());
        }
    }
}
