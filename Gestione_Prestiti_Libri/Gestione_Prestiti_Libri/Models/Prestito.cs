using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Prestiti_Libri.Models
{
    internal class Prestito
    {
        public int PrestitoID { get; set; }
        public DateTime DataPrestito { get; set; }
        public DateTime DataRitorno { get; set; }
        public int UtenteRIF { get; set; }
        public int LibroRIF { get; set; }

        public Prestito()
        {


        }

        public Prestito(int PrestitoID, DateTime DataPrestito, DateTime DataRitorno, int UtenteRIF, int LibroRIF)
        {
            this.PrestitoID = PrestitoID;
            this.DataPrestito = DataPrestito;
            this.DataRitorno = DataRitorno;
            this.UtenteRIF = UtenteRIF;
            this.LibroRIF = LibroRIF;
        }
    }
}
