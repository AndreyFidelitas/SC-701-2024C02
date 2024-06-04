using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IEquiposDA
    {
        //Listar los Equiposes
        public IEnumerable<Equipos> ListarEquipos();
        //Obtener el Equipos por medio del ID.
        public Equipos ListarEquipos(Guid Equipos);

    }
}
