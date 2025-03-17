using System;
using LocParcare;
using Masina;

namespace Tichet
{
    public class Bilete
    {
        public DetaliiMasina Masina { get; set; }
        public Loc Loc { get; set; }

        public Bilete(DetaliiMasina masina, Loc loc)
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