using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{

    [TestClass]
    public class WinstServiceTest
    {

        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private Mock<IOpbrengstDAO> mockOpbrengst;
        private Mock<IKostDAO> mockKost;
        [TestInitialize]
        public void Initialize()
        {
            mockOpbrengst = new Mock<IOpbrengstDAO>();
            opbrengstDAO = mockOpbrengst.Object;
            mockOpbrengst.Setup(eenOpbrengst => eenOpbrengst.TotaleOpbrengst()).Returns(200m);

            mockKost = new Mock<IKostDAO>();
            kostDAO = mockKost.Object;
            mockKost.Setup(eenKost => eenKost.TotaleKost()).Returns(169m);
            
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
            mockOpbrengst.Verify(eenOpbrengst => eenOpbrengst.TotaleOpbrengst());
            mockKost.Verify(eenKost => eenKost.TotaleKost());
        }
    }
}
