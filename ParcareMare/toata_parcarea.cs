using System;
using LocParcare;
using Masina;
using Tichet;

namespace ParcareMare
{
    public class toata_parcarea
    {
        private loc[] locuri;
        private detalii_masina[] masiniParcate;

        public toata_parcarea(int numarLocuri)
        {
            locuri = new loc[numarLocuri];
            masiniParcate = new detalii_masina[numarLocuri];

            for (int i = 0; i < numarLocuri; i++)
            {
                locuri[i] = new loc(i + 1);
            }
        }

        public bilete ParcheazaMasina(detalii_masina masina)
        {
            for (int i = 0; i < locuri.Length; i++)
            {
                if (!locuri[i].Ocupat)
                {
                    locuri[i].OcupaLoc();
                    masiniParcate[i] = masina;
                    return new bilete(masina, locuri[i]);
                }
            }

            Console.WriteLine("Nu sunt locuri disponibile.");
            return null;
        }

        public void ElibereazaLoc(int numarLoc)
        {
            if (numarLoc < 1 || numarLoc > locuri.Length)
            {
                Console.WriteLine("Loc invalid.");
                return;
            }

            if (masiniParcate[numarLoc - 1] != null)
            {
                masiniParcate[numarLoc - 1] = null;
                locuri[numarLoc - 1].ElibereazaLoc();
                Console.WriteLine($"Locul {numarLoc} a fost eliberat.");
            }
            else
            {
                Console.WriteLine("Locul este deja gol.");
            }
        }

        public detalii_masina GetMasina(string numarInmatriculare)
        {
            foreach (var masina in masiniParcate)
            {
                if (masina != null && masina.NumarInmatriculare == numarInmatriculare)
                {
                    return masina;
                }
            }
            return null;
        }

        public void AfisareMasini()
        {
            bool existaMasini = false;
            for (int i = 0; i < masiniParcate.Length; i++)
            {
                if (masiniParcate[i] != null)
                {
                    Console.WriteLine($"Loc {i + 1}: {masiniParcate[i].ToString()}");
                    existaMasini = true;
                }
            }

            if (!existaMasini)
            {
                Console.WriteLine("Nu sunt masini în parcare.");
            }
        }
    }
}
