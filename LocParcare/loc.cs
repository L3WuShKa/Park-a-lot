using System;

namespace LocParcare
{
    public class loc
    {
        public int NumarLoc { get; set; }
        public bool Ocupat { get; private set; }

        public loc(int numar)
        {
            NumarLoc = numar;
            Ocupat = false;
        }

        public void OcupaLoc()
        {
            Ocupat = true;
        }

        public void ElibereazaLoc()
        {
            Ocupat = false;
        }
    }
}
