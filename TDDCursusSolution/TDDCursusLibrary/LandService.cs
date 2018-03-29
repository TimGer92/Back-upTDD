using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
   public class LandService
    {
        private readonly ILandDAO landDAO;
        public decimal VerhoudingOppervlakteLandOppervlakteAlleLanden(string landcode)
        {
            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
    }
}
