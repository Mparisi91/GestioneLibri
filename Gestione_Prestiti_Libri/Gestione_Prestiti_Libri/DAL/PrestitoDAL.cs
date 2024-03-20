using Gestione_Prestiti_Libri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Prestiti_Libri.DAL
{
    internal class PrestitoDAL : IDal<Prestito>
    {
        private static PrestitoDAL? istanza;

        public static PrestitoDAL getIstanza()
        {
            if (istanza == null)
                istanza = new PrestitoDAL();

            return istanza;
        }
        private PrestitoDAL() { }
        public bool Delete(Prestito t)
        {
            throw new NotImplementedException();
        }

        public List<Prestito> GetAll()
        {
            throw new NotImplementedException();
        }

        public Prestito GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Prestito t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Prestito t)
        {
            throw new NotImplementedException();
        }
    }
}
