using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Prestiti_Libri.Models
{
    internal class Libro
    {
        public int LibroID { get; set; }
        public string? Titolo { get; set; }
        public int AnnoPubblicazione { get; set; }
        public bool Disponibile { get; set; }

        public Libro()
        {


        }
        public Libro(string? Titolo, int AnnoPubblicazione, bool Disponibile)
        {           
            this.Titolo = Titolo;
            this.AnnoPubblicazione = AnnoPubblicazione;
            this.Disponibile = Disponibile;
        }

        public Libro(int LibroID, string? Titolo, int AnnoPubblicazione, bool Disponibile)
        {
            this.LibroID = LibroID;
            this.Titolo = Titolo;
            this.AnnoPubblicazione = AnnoPubblicazione;
            this.Disponibile = Disponibile;
        }
    }
}
