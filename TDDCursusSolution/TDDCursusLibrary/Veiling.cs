﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal bod;
      public void DoeBod(decimal bedrag)
        {
           if(bedrag > bod)
            {
                bod = bedrag;
            }
        }
      public decimal HoogsteBod
        {
            get
            {
                return bod; 
            }
        }


    }
}
