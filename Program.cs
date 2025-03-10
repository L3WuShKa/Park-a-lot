using System;
using ParcareMare;
using Masina;

namespace Parking
{
    class Program
    {
        static void Main()
        {
            toata_parcarea parcare = new toata_parcarea(5);
            detalii_masina masina1 = new detalii_masina("B-123-XYZ", "Andrei Popescu");
            detalii_masina masina2 = new detalii_masina("SV-42-SME", "Ruben Iacob Levi");
            var tichet = parcare.ParcheazaMasina(masina1);
            var tichet2 = parcare.ParcheazaMasina(masina2);

            if (tichet != null && tichet2 != null)
            {
                Console.WriteLine(tichet);
                Console.WriteLine(tichet2);
            }


                // Afișăm toate mașinile parcate
                Console.WriteLine("Masinile parcate:");
            parcare.AfisareMasini();

            // Căutăm o mașină
            var masinaGasita = parcare.GetMasina("B-123-XYZ");
            if (masinaGasita != null)
            {
                Console.WriteLine($"Masina găsită: {masinaGasita}");
            }

            // Eliberăm un loc
            parcare.ElibereazaLoc(1);
        }
    }
}
