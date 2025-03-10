using System;
using LocParcare;
using Masina;

namespace Tichet
{
    public class bilete
    {
        public detalii_masina Masina { get; set; }
        public loc Loc { get; set; }

        public bilete(detalii_masina masina, loc loc)
        {
            Masina = masina;
            Loc = loc;
        }

        public override string ToString()
        {
            return $"Tichet: {Masina} - Loc {Loc.NumarLoc}";
        }
    }
}
