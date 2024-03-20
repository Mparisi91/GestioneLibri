using Gestione_Prestiti_Libri.DAL;
using Gestione_Prestiti_Libri.Models;

namespace Gestione_Prestiti_Libri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Libro lib = new Libro()
            {
                Titolo = "Il Signore agnelli",
                AnnoPubblicazione = 2023,
                Disponibile = true
            };

            Console.WriteLine(LibroDAL.getIstanza().Insert(lib) ? "Stappo!" : "Errore");

            Libro libDaEliminare = new Libro()
            {
                LibroID = 1
            };

            bool eliminazioneRiuscita = LibroDAL.getIstanza().Delete(libDaEliminare);
            Console.WriteLine(eliminazioneRiuscita ? "Eliminazione riuscita!" : "Errore durante l'eliminazione");

            Console.ReadLine();
        }
    }
}
