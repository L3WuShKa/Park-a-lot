using System;

namespace Masina
{
    public class detalii_masina
    {
        public string NumarInmatriculare { get; set; }
        public string Proprietar { get; set; }

        public detalii_masina(string numar, string proprietar)
        {
            NumarInmatriculare = numar;
            Proprietar = proprietar;
        }

        public override string ToString()
        {
            return $"Masina {NumarInmatriculare}, Proprietar: {Proprietar}";
        }
    }
}
