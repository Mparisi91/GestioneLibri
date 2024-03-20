using Gestione_Prestiti_Libri.Models;
using Gestione_Prestiti_Libri.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Prestiti_Libri.DAL
{
    internal class LibroDAL : IDal<Libro>
    {
        private static LibroDAL? istanza;

        public static LibroDAL getIstanza()
        {
            if (istanza == null)
                istanza = new LibroDAL();

            return istanza;
        }
        private LibroDAL() { }
        public bool Delete(Libro t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Libro WHERE libroID = @LibroID";
                cmd.Parameters.AddWithValue("@LibroID", t.LibroID);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }

        public List<Libro> GetAll()
        {
            throw new NotImplementedException();
        }

        public Libro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro t)
        {
            bool risultato = false;
           
            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))

            {          
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Libro(titolo, annoPubblicazione, Disponibile) VALUES (@Titolo, @AnnoPubblicazione, @Disponibile)";
                cmd.Parameters.AddWithValue("@Titolo", t.Titolo);
                cmd.Parameters.AddWithValue("@AnnoPubblicazione", t.AnnoPubblicazione);
                cmd.Parameters.AddWithValue("@Disponibile", t.Disponibile);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() >0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }

        public bool Update(Libro t)
        {
            throw new NotImplementedException();
        }
    }
}
