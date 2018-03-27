using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningNummerTest
    {
        [TestMethod]
        public void NummerMet12CijfersMetCorrectControleIsOK()
        {
            new RekeningNummer("063-1547564-61");//dit nummer mag geen exception veroorzaken
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersMetVerkeerdeControleIsVerkeerd()
        {
            new RekeningNummer("063-1547564-62");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersZonderStreepjesMetCorrectControleIsVerkeerd()
        {
            new RekeningNummer("063154756461");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersIsVerkeerd()
        {
            new RekeningNummer("063-1547564-623");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet11CijfersIsVerkeerd()
        {
            new RekeningNummer("063-1547564-6");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LeegNummerIsVerkeerd()
        {
            new RekeningNummer(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void nummerMetNullIsVerkeerd()
        {
            new RekeningNummer(null);
        }

        [TestMethod]
        public void toStringMoetHetNummerTeruggeven()
        {
            var nummer = "063-1547564-61";
            var rekeningnummer = new RekeningNummer(nummer);
            Assert.AreEqual(nummer, rekeningnummer.ToString());
        }



    }
}
