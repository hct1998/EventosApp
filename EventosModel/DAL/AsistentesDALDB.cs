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

        public void Actualizar(Asistente a)
        {
            Asistente aOriginal = this.eventosDB.Asistentes.Find(a.Id);
            aOriginal.Estado = a.Estado;
            aOriginal.Nombre = a.Nombre;
            aOriginal.Apellido = a.Apellido;
            aOriginal.Edad = a.Edad;
            this.EventosDB.SaveChanges();
        }

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
            return this.EventosDB.Asistentes.Find(id);
        }

        public List<Asistente> ObtenerAsistentes()
        {
            return this.EventosDB.Asistentes.ToList();
        }

        public List<Asistente> ObtenerAsistentes(string estado)
        {
            var query = from a in this.EventosDB.Asistentes
                        where a.Estado == estado
                        select a;
            return query.ToList();
        }
    }
}
