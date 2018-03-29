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
            throw new NotImplementedException();
        }
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
    }
}
