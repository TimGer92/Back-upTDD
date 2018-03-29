using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class ISBN
    {
        private const long GrootsteGetal = 9999999999999L;
        private const long KleinsteGetal = 1000000000000L;
        private long nummer;
        public ISBN(long nummer)
        {
            if (nummer < KleinsteGetal || nummer > GrootsteGetal)
            {
                throw new ArgumentException();
            }
            var somEven = 0L;
            var somOnEven = 0L;
            var alleCijfers = nummer / 10;
            for (int i = 0; i != 6; i++)
            {
                somEven += alleCijfers % 10;
                alleCijfers /= 10;
                somOnEven += alleCijfers % 10;
                alleCijfers /= 10;
            }
            var controle = (somEven * 3) + somOnEven;
            var hoger10Tal = controle - controle % 10 + 10;
            var verschil = hoger10Tal - controle;
            var laatsteCijfer = nummer % 10;
            if (verschil == 10)
            {
                if (laatsteCijfer != 0)
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                if (laatsteCijfer != verschil)
                {
                    throw new ArgumentException();
                }
            }
                this.nummer = nummer;
        }

        public override string ToString()
        {
            return nummer.ToString();
        }
    }
}
