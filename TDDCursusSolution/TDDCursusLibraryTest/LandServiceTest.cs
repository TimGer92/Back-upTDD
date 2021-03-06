﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private Mock<ILandDAO> mockFactory;
        private ILandDAO landDAO;
        private LandService landService;
        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;
            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });
            landService = new LandService(landDAO);
        }

        [TestMethod]
        public void VerhoudingOppervlakteLandToOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m,
                landService.VerhoudingOppervlakteLandOppervlakteAlleLanden("B"));
            mockFactory.Verify(eenLandDao => eenLandDao.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));

        }
    }
}
