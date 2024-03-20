using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Prestiti_Libri.Models
{
    internal class Utente
    {
        public int UtenteID { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }

        public Utente()
        {


        }
        public Utente(string? Nome, string? Cognome, string? Email)
        {           
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
        }

        public Utente(int UtenteID, string? Nome, string? Cognome, string? Email)
        {
            this.UtenteID = UtenteID;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
        }
    }
}
