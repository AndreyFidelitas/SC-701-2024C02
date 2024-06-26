﻿using Abstracciones.Modelos;
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
        public Task<IEnumerable<Equipos>> ListarEquipos();
        //Obtener el Equipos por medio del ID.
        public Task<Equipos> ListarEquipos(Guid Equipos);

    }
}
