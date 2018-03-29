using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class WinstService
    {
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IKostDAO kostDAO;
        
        public decimal Winst
        {
            get
            {
                return opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();
            }
        }
  
        public WinstService(IOpbrengstDAO opbrengst,IKostDAO kost)
        {
            opbrengstDAO = opbrengst;
            kostDAO = kost;
        }
    }
}
