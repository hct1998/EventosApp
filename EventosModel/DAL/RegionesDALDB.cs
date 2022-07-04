using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public class RegionesDALDB : IRegionesDAL
    {
        //intanciar la base de datos
        private EventosDBEntities EventosDB = new EventosDBEntities();

        //retornar los datos
        public List<Region> ObtenerRegiones()
        {
            return this.EventosDB.Regions.ToList();
        }
    }
}
