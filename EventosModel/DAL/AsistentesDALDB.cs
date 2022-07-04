using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public class AsistentesDALDB : IAsistentesDAL
    {

        private EventosDBEntities EventosDB = new EventosDBEntities();
        public void AgregarAsistente(Asistente asistente)
        {
            this.EventosDB.Asistentes.Add(asistente);
            this.EventosDB.SaveChanges();
        }

        public void EliminarAsistente(int id)
        {
            //buscar asistente con el id
            Asistente asistente = this.EventosDB.Asistentes.Find(id);
            //eliminar el asistente
            this.EventosDB.Asistentes.Remove(asistente);
            this.EventosDB.SaveChanges();
        }

        public Asistente Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public List<Asistente> ObtenerAsistentes()
        {
            throw new NotImplementedException();
        }

        public List<Asistente> ObtenerAsistentes(string estado)
        {
            throw new NotImplementedException();
        }
    }
}
